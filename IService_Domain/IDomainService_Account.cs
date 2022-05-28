using BaseDB;
using System.Threading.Tasks;

namespace IService_Domain
{
    public interface IDomainService_Account
    {
        Task<PersonType> 注册账号_DBAsync(string accountNumber, string passWord, string name);

        Task 修改密码_DBAsync(string acccountId, string passWord);

        Task 修改姓名_DBAsync(string acccountId, string name);

        Task<PersonType> 登录Async(string accountNumber, string passWord);
    }
}