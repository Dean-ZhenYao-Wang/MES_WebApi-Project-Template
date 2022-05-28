using BaseDB;
using IRepository_DB;
using IService_Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Service_Domain.Services
{
    public class DomainService_Menu : IDomainService_Menu
    {
        private readonly IRepository<菜单> 菜单;
        private readonly IRepository<角色_菜单> 角色的可访问菜单;

        public DomainService_Menu(IUnitOfWork unitOfWork)
        {
            菜单 = unitOfWork.菜单;
            角色的可访问菜单 = unitOfWork.角色_菜单s;
        }

        public async Task 新增菜单_DBAsync(string name, string url, string 编号, int 序号, string iCON, string 上级菜单Id)
        {
            菜单 menu = new 菜单
            {
                Key = Guid.NewGuid().ToString(),
                名称 = name,
                Url = url,
                编号 = 编号,
                序号 = 序号,
                ICON = iCON,
                上级菜单Key = 上级菜单Id
            };
            menu.记录创建人及创建时间();
            await 菜单.AddAsync(menu);
        }

        public async Task 修改菜单_DBAsync(string menuId, string name, string url, string 编号, int 序号, string iCON, string 上级菜单Id)
        {
            var menu = await 菜单.All().Where(m => m.Key.Equals(menuId)).FirstAsync();
            menu.名称 = name;
            menu.Url = url;
            menu.编号 = 编号;
            menu.序号 = 序号;
            menu.ICON = iCON;
            menu.上级菜单Key = 上级菜单Id;
            menu.记录修改人及修改时间();
        }

        public async Task 删除菜单_DBAsync(string menuId)
        {
            var menu = await 菜单.All().Where(m => m.Key.Equals(menuId)).FirstAsync();
            menu.删除();
            var role_x_menu = await 角色的可访问菜单.All().Where(m => m.IsDelete == false && m.菜单Key.Equals(menuId)).ToListAsync();
            role_x_menu.ForEach(m =>
            {
                m.删除();
            });
        }

        public async Task<List<菜单>> 获取菜单列表_DBAsync()
        {
            var 顶级菜单列表 = await 菜单.All().Where(m => m.IsDelete == false)
                .Where(m => m.上级菜单Key == null)
                .OrderBy(m => m.序号)
                .ToListAsync();
            return 顶级菜单列表;
        }
    }
}