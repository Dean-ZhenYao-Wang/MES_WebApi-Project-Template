using BaseDB;
using IRepository_DB;
using IService_Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Service_Domain.Services
{
    public class DomainService_Account : IDomainService_Account
    {
        private readonly IRepository<用户> 用户;

        public DomainService_Account(IUnitOfWork unitOfWork)
        {
            用户 = unitOfWork.用户;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="accountNumber">账号</param>
        /// <param name="passWord">密码</param>
        /// <param name="name">姓名</param>
        /// <returns></returns>
        public async Task<用户> 注册账号_DBAsync(string accountNumber, string passWord, string name)
        {
            BaseDB.用户 account = new 用户
            {
                Key = Guid.NewGuid().ToString(),
                登录用户名 = accountNumber,
                昵称 = name,
                密码 = passWord
            };
            account.记录创建人及创建时间();
            await 用户.AddAsync(account);
            return account;
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="acccountId">账号Id</param>
        /// <param name="passWord">新密码</param>
        public async Task 修改密码_DBAsync(string acccountId, string passWord)
        {
            var account = await 用户.All().FirstAsync(m => m.Key.Equals(acccountId));
            account.密码 = passWord;
            account.记录修改人及修改时间();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="acccountId">账号Id</param>
        /// <param name="name">新姓名</param>
        public async Task 修改姓名_DBAsync(string acccountId, string name)
        {
            var account = await 用户.All().FirstAsync(m => m.Key.Equals(acccountId));
            account.昵称 = name;
            account.记录修改人及修改时间();
        }

        /// <summary>
        ///
        /// </summary>
        /// <param name="accountNumber">登录账号</param>
        /// <param name="passWord">密码</param>
        /// <returns></returns>
        public async Task<用户> 登录Async(string accountNumber, string passWord)
        {
            return await 用户.All()
                .Where(m => m.IsDelete == false && m.登录用户名.Equals(accountNumber) && m.密码.Equals(passWord))
                .FirstOrDefaultAsync();
        }
    }
}