using BaseDB;
using FluentValidation;
using IRepository_DB;
using IService_Domain;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Service_Domain;
using System;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Util;
using Util.Model;
using WebApi.Controllers.AccountManage.Request;

namespace WebApi.Controllers.AccountManage
{
    /// <summary>
    /// 账号管理
    /// </summary>
    /// <remarks>
    /// 注册账号
    /// 登录
    /// 修改密码
    /// 修改姓名
    /// </remarks>
    public class AccountManageController : BaseController
    {
        private readonly IDomainService_Account domainService_Account;
        private readonly IDomainService_People domainService_People;
        private readonly IConfiguration configuration;
        /// <summary>
        /// 构造函数
        /// </summary>
        public AccountManageController(IDomainService_Account domainService_Account, IDomainService_People domainService_People, IUnitOfWork unitOfWork, IMediator mediator, IConfiguration configuration) : base(unitOfWork, mediator)
        {
            this.domainService_Account = domainService_Account;
            this.domainService_People = domainService_People;
            this.configuration = configuration;
        }


        /// <summary>
        /// 注册账号
        /// </summary>
        /// <param name="inputDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route(nameof(注册账号))]
        public async Task 注册账号(注册账号_Request inputDto)
        {
            用户 people;

            people = await domainService_Account.注册账号_DBAsync(inputDto.AccountNumber, inputDto.PassWord, inputDto.Name);
            await SaveAsync();

            await Publish(new 新增用户Event(people));
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="inputDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route(nameof(登录))]
        [AllowAnonymous]
        public async Task<AjaxResult<string>> 登录(登录_Dto inputDto)
        {
            var account = await this.domainService_Account.登录Async(inputDto.AccountNumber, inputDto.PassWord);
            if (account == null)
                throw new BusinessException("用户名或密码错误");

            var jwtConfig = configuration.GetSection("Jwt");
            //秘钥，就是标头，这里用Hmacsha256算法，需要256bit的密钥
            var securityKey = new SigningCredentials(new SymmetricSecurityKey(Encoding.ASCII.GetBytes(jwtConfig.GetValue<string>("Secret"))), SecurityAlgorithms.HmacSha256);
            //Claim，JwtRegisteredClaimNames中预定义了好多种默认的参数名，也可以像下面的Guid一样自己定义键名.
            //ClaimTypes也预定义了好多类型如role、email、name。Role用于赋予权限，不同的角色可以访问不同的接口
            //相当于有效载荷
            var claims = new Claim[] {
                new Claim(JwtRegisteredClaimNames.Iss,jwtConfig.GetValue<string>("Iss")),
                new Claim(JwtRegisteredClaimNames.Aud,jwtConfig.GetValue<string>("Aud")),
                new Claim("Guid",account.Key.ToString()),
            };
            SecurityToken securityToken = new JwtSecurityToken(
                signingCredentials: securityKey,
                expires: DateTime.Now.AddHours(8),//过期时间
                claims: claims
            );
            //生成jwt令牌
            return Success<string>(new JwtSecurityTokenHandler().WriteToken(securityToken));
        }
        public class LoginRequest
        {
            public string Token { get; set; }
            public 用户 Account { get; set; }
        }

        /// <summary>
        /// 修改密码
        /// </summary>
        /// <param name="inputDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route(nameof(修改密码))]
        public async Task 修改密码(修改密码_Dto inputDto)
        {
            await domainService_Account.修改密码_DBAsync(HttpContextHelper<MyJWTPayload>.CurrentLoginUser.Key, inputDto.PassWordOne);
            await SaveAsync();
            await Publish(new 修改密码Event(HttpContextHelper<MyJWTPayload>.CurrentLoginUser.Key, inputDto.PassWordOne));
        }

        /// <summary>
        /// 修改姓名
        /// </summary>
        /// <param name="name">新的名字</param>
        /// <returns></returns>
        [HttpPost]
        [Route(nameof(修改姓名) + "/{name}")]
        public async Task 修改姓名(string name)
        {
            await domainService_Account.修改姓名_DBAsync(HttpContextHelper<MyJWTPayload>.CurrentLoginUser.Key, name);
            await SaveAsync();
        }

        /// <summary>
        /// 登录时提供给后端的信息
        /// </summary>
        public class 登录_Dto
        {
            /// <summary>
            /// 账号
            /// </summary>
            [Required]
            public string AccountNumber { get; set; }

            /// <summary>
            /// 密码
            /// </summary>
            [Required]
            public string PassWord { get; set; }
        }

        /// <summary>
        /// 修改密码时提供给后端的信息
        /// </summary>
        public class 修改密码_Dto
        {
            /// <summary>
            /// 第一遍密码
            /// </summary>
            public string PassWordOne { get; set; }

            /// <summary>
            /// 第二遍重复第一遍的密码
            /// </summary>
            public string PassWordTwo { get; set; }
        }
        //把校验规则写到单独的文件，也是DDD的一种原则
        public class 修改密码_DtoValidator : AbstractValidator<修改密码_Dto>
        {
            public 修改密码_DtoValidator()
            {
                RuleFor(x => x.PassWordOne).NotEmpty();
                RuleFor(x => x.PassWordOne).NotNull().Length(1, 200);
                RuleFor(x => x.PassWordTwo).NotNull().Length(1, 200);
                RuleFor(x => x.PassWordOne).NotEqual(x => x.PassWordTwo).WithMessage(c => $"两次密码不一致");
            }
        }
    }
}