﻿using BaseDB;
using System.Collections.Generic;
using System.Threading.Tasks;
using Util.Model;

namespace IService_Domain
{
    public interface IDomainService_Role
    {
        Task 修改角色名称_DBAsync(string roleId, string name);

        Task 删除角色_DBAsync(string roleId);

        Task<PersonnelClassType> 新增角色_DBAsync(string name);

        Task<PagedList<PersonnelClassType>> 查询角色列表_DBAsync(int pageIndex, int pageSize, bool? isDelete = null);

        Task<PersonnelClassType> 获取指定角色信息_DBAsync(string roleId);

        Task 设置角色可访问菜单_DBAsync(string roleId, List<string> list_MenuId);
    }
}