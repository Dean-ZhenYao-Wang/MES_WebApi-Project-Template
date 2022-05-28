using BaseDB;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IService_Domain
{
    public interface IDomainService_Menu
    {
        Task 修改菜单_DBAsync(string menuId, string name, string url, string 编号, int 序号, string iCON, string 上级菜单Id);

        Task 删除菜单_DBAsync(string menuId);

        Task 新增菜单_DBAsync(string name, string url, string 编号, int 序号, string iCON, string 上级菜单Id);

        Task<List<菜单>> 获取菜单列表_DBAsync();
    }
}