using BaseDB;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Util.Model;

namespace IService_Domain
{
    public interface IDomainService_Role
    {
        Task 修改角色名称_DBAsync(Guid roleId, string name);

        Task 删除角色_DBAsync(Guid roleId);

        Task<角色> 新增角色_DBAsync(string name);

        Task<PagedList<角色>> 查询角色列表_DBAsync(int pageIndex, int pageSize, bool? isDelete = null);

        Task<角色> 获取指定角色信息_DBAsync(Guid roleId);

        Task 设置角色可访问菜单_DBAsync(Guid roleId, List<Guid> list_MenuId);
    }
}