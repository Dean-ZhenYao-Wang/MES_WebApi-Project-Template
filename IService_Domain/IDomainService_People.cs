using BaseDB;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Util.Model;

namespace IService_Domain
{
    public interface IDomainService_People
    {

        Task 删除用户_DBAsync(List<Guid> listPeopleId);

        Task<用户> 新增用户_DBAsync(string accountNumber, string name, List<Guid> list_OrgId = null, List<Guid> list_RoleId = null);

        Task<PagedList<用户>> 查询用户列表_DBAsync(int pageIndex, int pageSize, bool? isDelete = null);

        Task 修改用户信息_DBAsync(Guid peopleId, string accountNumber, string name, string name1, List<Guid> list_OrgId = null, List<Guid> list_RoleId = null);
    }
}