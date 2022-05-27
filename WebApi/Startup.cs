using BaseDB;
using FluentValidation.AspNetCore;
using IGeekFan.AspNetCore.Knife4jUI;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;
using Util;
using Util.Helper;
using Util.Middleware;

namespace WebApi
{
    public class Startup
    {
        private static readonly string thisSolution = "WebApi";
        private static readonly string thisNamespace = $"{thisSolution} WebAPI";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            #region 使用System.Text.Json时，可将此处内容取消注释，此处的作用是：将json中的中文字符不做转义
            //var fieldInfo = typeof(JsonSerializerOptions).GetField("s_defaultOptions", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Instance);

            //var options = fieldInfo.GetValue(null) as JsonSerializerOptions;
            //options.Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping;
            #endregion

            services.AddControllers(options =>
            {
                options.Filters.Add<GlobalExceptionFilter>();
            }).ConfigureApiBehaviorOptions(o =>
            {
                o.SuppressModelStateInvalidFilter = true;
            })
           .AddControllersAsServices()
           .AddNewtonsoftJson(options =>
           {
               options.SerializerSettings.MissingMemberHandling = MissingMemberHandling.Ignore;
               options.SerializerSettings.PreserveReferencesHandling = PreserveReferencesHandling.Objects;
               options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
           });
            services.AddLogging();
#if DEBUG
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1.0.0",
                    Title = $"{thisNamespace}\n\n接口文档"
                });
                // JWT认证
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Scheme = "bearer",
                    BearerFormat = "JWT",
                    Type = SecuritySchemeType.Http,
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Description = "Authorization:Bearer {your JWT token}<br/><b>授权地址:/api/AccountManage/登录</b>",
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme{Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            }
                        },
                        new string[] { }
                    }
                });
                // 为 Swagger JSON and UI设置xml文档注释路径
                var basePath = Path.GetDirectoryName(typeof(Program).Assembly.Location);//获取应用程序所在目录（绝对，不受工作目录影响，建议采用此方法获取路径）

                //控制器层
                c.IncludeXmlComments(Path.Combine(basePath, $"{thisSolution}.xml"), true);

                IEnumerable<string> files = Directory.GetFiles(basePath).Where(m => m.Contains(".xml") && !m.Contains($"{thisSolution}.xml"));
                foreach (var file in files)
                {
                    c.IncludeXmlComments(file);
                }
            });
#endif
            services.AddFluentValidation(options =>
            {
                options.RegisterValidatorsFromAssembly(Assembly.GetEntryAssembly());
            });
            var assemblies = ReflectionHelper.GetAllReferencedAssemblies();
            services.RunModuleInitializers(assemblies);
            services.AddDbContext<BaseDbContext>(options =>
            {
                options.UseSqlServer(Configuration["ConnectionStrings:BaseDbConnectionString"]);
            });

            using (IServiceScope scope = services.BuildServiceProvider().CreateScope())
            {
                var service = scope.ServiceProvider;
                var context = service.GetRequiredService<BaseDbContext>();
                DbInitializer.Initialize(context);
            }
            services.AddMediatR(assemblies.ToArray());
            var jwtConfig = Configuration.GetSection("Jwt");
            var symmetricKeyAsBae64 = jwtConfig.GetValue<string>("Secret");
            var keyByteArray = Encoding.ASCII.GetBytes(symmetricKeyAsBae64);
            var signingKey = new SymmetricSecurityKey(keyByteArray);
            services
                .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,//是否验证签名,不验证的话可以篡改数据，不安全
                        IssuerSigningKey = signingKey,//解密的密钥
                        ValidateIssuer = true,//是否验证发行人，就是验证载荷中的Iss是否对应ValidIssuer参数
                        ValidIssuer = jwtConfig.GetValue<string>("Iss"),//发行人
                        ValidateAudience = false,//是否验证订阅人，就是验证载荷中的Aud是否对应ValidAudience参数
                        ValidAudience = jwtConfig.GetValue<string>("Aud"),//订阅人
                        ValidateLifetime = true,//是否验证过期时间，过期了就拒绝访问
                        ClockSkew = TimeSpan.Zero,//这个是缓冲过期时间，也就是说，即使我们配置了过期时间，这里也要考虑进去，过期时间+缓冲，默认好像是7分钟，你可以直接设置为0
                        RequireExpirationTime = true,
                    };
                    options.Events = new JwtBearerEvents()
                    {
                        OnAuthenticationFailed = context =>
                        {
                            if (context.Exception.GetType() == typeof(SecurityTokenExpiredException))
                            {
                                context.Response.Headers.Add("Toke-Expired", "true");
                            }
                            return Task.CompletedTask;
                        }
                    };
                });
            services.AddHttpContextAccessor();
            services.AddScoped<HttpContextHelper>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseMiddleware<CorsMiddleware>();
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            //Swagger配置
            app.UseSwagger()
               .UseSwaggerUI(c =>
               {
                   c.SwaggerEndpoint("/swagger/v1/swagger.json", "1.0.0");
               });
            app.UseKnife4UI(c =>
            {
                c.RoutePrefix = string.Empty;
                c.SwaggerEndpoint($"/swagger/v1/swagger.json", "1.0.0");
            });
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseHttpContextHelperMiddleware();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}