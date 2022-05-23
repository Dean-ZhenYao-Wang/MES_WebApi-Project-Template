using FluentValidation;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Controllers.AccountManage.Request
{
    /// <summary>
    /// 注册账号时提供给后端的信息
    /// </summary>
    public class 注册账号_Request
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// 登录账号
        /// </summary>
        [Required]
        public string AccountNumber { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [Required]
        public string PassWord { get; set; }
    }
    public class 注册账号_RequestValidator : AbstractValidator<注册账号_Request>
    {
        public 注册账号_RequestValidator(BaseDB.BaseDbContext dbCtx)
        {
            RuleFor(x => x.AccountNumber).NotEmpty();
            RuleFor(x => x.Name).NotEmpty().Length(1, 200);
            RuleFor(x => x.AccountNumber)
                .MustAsync(async (x, ct) =>
                {
                    var tf = await dbCtx.用户.AnyAsync(m => m.登录用户名.Equals(x));
                    return !tf;
                })
                .WithMessage(x => $"账号已存在");
            RuleFor(x => x.Name)
                .MustAsync(async (x, ct) =>
                {
                    var tf = await dbCtx.用户.AnyAsync(m => m.昵称.Equals(x));
                    return !tf;
                })
                .WithMessage(x => $"昵称已被占用");
        }
    }
}
