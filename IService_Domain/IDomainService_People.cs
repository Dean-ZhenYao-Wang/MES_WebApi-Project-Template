using BaseDB;
using System.Collections.Generic;
using System.Threading.Tasks;
using Util.Model;

namespace IService_Domain
{
    public interface IDomainService_People
    {
        Task 删除用户_DBAsync(List<string> listPeopleId);

        Task<PersonType> 新增用户_DBAsync(string accountNumber, string name, List<string> list_OrgId = null, List<string> list_RoleId = null);

        Task<PagedList<PersonType>> 查询用户列表_DBAsync(int pageIndex, int pageSize, bool? isDelete = null);

        Task 修改用户信息_DBAsync(string peopleId, string accountNumber, string name, string name1, List<string> list_OrgId = null, List<string> list_RoleId = null);
    }
}