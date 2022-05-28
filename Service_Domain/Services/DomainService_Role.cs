using BaseDB;
using IRepository_DB;
using IService_Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Util;
using Util.Model;

namespace Service_Domain.Services
{
    public class DomainService_Role : IDomainService_Role
    {
        private readonly IRepository<PersonnelClassType> 角色;
        private readonly IRepository<角色_菜单> 角色的可访问菜单;

        public DomainService_Role(IUnitOfWork unitOfWork)
        {
            角色 = unitOfWork.PersonnelClasses;
            角色的可访问菜单 = unitOfWork.角色_菜单s;
        }

        public async Task<PersonnelClassType> 新增角色_DBAsync(string name)
        {
            PersonnelClassType role = new PersonnelClassType()
            {
                Key = Guid.NewGuid().ToString(),
                Id = new IdentifierType { Value = name }
            };
            role.记录创建人及创建时间();
            await 角色.AddAsync(role);
            return role;
        }

        public async Task 修改角色名称_DBAsync(string roleId, string name)
        {
            var role = await 角色.All().Where(m => m.Key.Equals(roleId)).FirstAsync();

            role.Id.Value = name;
            role.记录修改人及修改时间();
        }

        public async Task 删除角色_DBAsync(string roleId)
        {
            var role = await 角色.All().Where(m => m.Key.Equals(roleId)).FirstAsync();
            role.删除();
        }

        public async Task<PagedList<PersonnelClassType>> 查询角色列表_DBAsync(int pageIndex, int pageSize, bool? isDelete = null)
        {
            return await 角色.All()
                .Where(role => isDelete == null || role.IsDelete == isDelete)
                .AsNoTracking()
                .ToPagedListAsync(pageIndex, pageSize);
        }

        public async Task<PersonnelClassType> 获取指定角色信息_DBAsync(string roleId)
        {
            return await 角色.All()
                 .Where(role => role.Key.Equals(roleId))
                 .AsNoTracking()
                 .FirstAsync();
        }

        public async Task 设置角色可访问菜单_DBAsync(string roleId, List<string> list_MenuId)
        {
            var oldMenu_List = await 角色的可访问菜单.All()
                .Where(rxm => rxm.IsDelete == false && rxm.角色Key.Equals(roleId))
                .Select(rxm => rxm)
                .ToListAsync();
            if (list_MenuId == null || !list_MenuId.Any())
            {
                oldMenu_List.ForEach(m =>
                {
                    m.删除();
                });
                return;
            }
            var oldMenuId_List = oldMenu_List.Select(m => m.菜单Key).ToList();

            var deleteMenuId_List = oldMenuId_List.Except(list_MenuId);
            var deleteMenu_List = oldMenu_List.Where(m => deleteMenuId_List.Contains(m.菜单Key)).ToList();
            deleteMenu_List.ForEach(m =>
            {
                m.删除();
            });

            var addMenuId_List = list_MenuId.Where(m => !oldMenuId_List.Contains(m)).ToList();
            if (addMenuId_List.Any())
            {
                List<角色_菜单> addMenulist = new List<角色_菜单>();
                addMenuId_List.ForEach(menuId =>
                {
                    var menu = new 角色_菜单()
                    {
                        Key = Guid.NewGuid().ToString(),
                        角色Key = roleId,
                        菜单Key = menuId
                    };
                    menu.记录创建人及创建时间();
                    addMenulist.Add(menu);
                });
                await 角色的可访问菜单.AddRangeAsync(addMenulist);
            }
        }
    }
}