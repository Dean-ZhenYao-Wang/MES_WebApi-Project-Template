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
            #region ʹ��System.Text.Jsonʱ���ɽ��˴�����ȡ��ע�ͣ��˴��������ǣ���json�е������ַ�����ת��
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
                    Title = $"{thisNamespace}\n\n�ӿ��ĵ�"
                });
                // JWT��֤
                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Scheme = "bearer",
                    BearerFormat = "JWT",
                    Type = SecuritySchemeType.Http,
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Description = "Authorization:Bearer {your JWT token}<br/><b>��Ȩ��ַ:/api/AccountManage/��¼</b>",
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
                // Ϊ Swagger JSON and UI����xml�ĵ�ע��·��
                var basePath = Path.GetDirectoryName(typeof(Program).Assembly.Location);//��ȡӦ�ó�������Ŀ¼�����ԣ����ܹ���Ŀ¼Ӱ�죬������ô˷�����ȡ·����

                //��������
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
                        ValidateIssuerSigningKey = true,//�Ƿ���֤ǩ��,����֤�Ļ����Դ۸����ݣ�����ȫ
                        IssuerSigningKey = signingKey,//���ܵ���Կ
                        ValidateIssuer = true,//�Ƿ���֤�����ˣ�������֤�غ��е�Iss�Ƿ��ӦValidIssuer����
                        ValidIssuer = jwtConfig.GetValue<string>("Iss"),//������
                        ValidateAudience = false,//�Ƿ���֤�����ˣ�������֤�غ��е�Aud�Ƿ��ӦValidAudience����
                        ValidAudience = jwtConfig.GetValue<string>("Aud"),//������
                        ValidateLifetime = true,//�Ƿ���֤����ʱ�䣬�����˾;ܾ�����
                        ClockSkew = TimeSpan.Zero,//����ǻ������ʱ�䣬Ҳ����˵����ʹ���������˹���ʱ�䣬����ҲҪ���ǽ�ȥ������ʱ��+���壬Ĭ�Ϻ�����7���ӣ������ֱ������Ϊ0
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
            //Swagger����
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