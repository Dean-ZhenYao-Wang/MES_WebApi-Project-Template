using BaseDB;
using IRepository_DB;
using IService_Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Util.Model;

namespace WebApi.Controllers.RoleManage
{
    /// <summary>
    /// 角色管理
    /// </summary>
    public class RoleManageController : BaseController
    {
        private readonly IDomainService_Role domainService_Role;

        /// <summary>
        /// 构造函数
        /// </summary>
        public RoleManageController(IDomainService_Role domainService_Role, IUnitOfWork unitOfWork, IMediator mediator) : base(unitOfWork, mediator)
        {
            this.domainService_Role = domainService_Role;
        }

        /// <summary>
        /// 新增角色
        /// </summary>
        /// <param name="name">需要新增的角色名称</param>
        /// <returns></returns>
        [HttpPost]
        [Route(nameof(新增角色) + "/{name}")]
        public async Task 新增角色(string name)
        {
            _ = await domainService_Role.新增角色_DBAsync(name);
            await SaveAsync();
        }

        /// <summary>
        /// 修改角色名称
        /// </summary>
        /// <param name="inputDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route(nameof(修改角色名称))]
        public async Task 修改角色名称(修改角色名称_Dto inputDto)
        {
            await domainService_Role.修改角色名称_DBAsync(inputDto.RoleId, inputDto.Name);
            await SaveAsync();
        }

        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="roleId">需要被删除的角色的Id</param>
        /// <returns></returns>
        [HttpPost]
        [Route(nameof(删除角色) + "/{roleId}")]
        public async Task 删除角色(string roleId)
        {
            await domainService_Role.删除角色_DBAsync(roleId);
            await SaveAsync();
        }

        /// <summary>
        /// 查询角色列表
        /// 此处返回类型还需在此处再次转换成VO
        /// </summary>
        /// <param name="inputDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route(nameof(查询角色列表))]
        public async Task<PagedList<PersonnelClassType>> 查询角色列表(查询角色列表_Dto inputDto)
        {
            return await domainService_Role.查询角色列表_DBAsync(inputDto.PageIndex, inputDto.PageSize);
        }

        /// <summary>
        /// 获取指定角色信息
        /// 此处返回类型还需在此处再次转换成VO
        /// </summary>
        /// <param name="roleId">要获取信息的角色的Id</param>
        /// <returns></returns>
        [HttpPost]
        [Route(nameof(获取指定角色信息) + "/{roleId}")]
        public async Task<PersonnelClassType> 获取指定角色信息(string roleId)
        {
            return await domainService_Role.获取指定角色信息_DBAsync(roleId);
        }

        /// <summary>
        /// 设置角色可访问菜单
        /// </summary>
        /// <param name="inputDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route(nameof(设置角色可访问菜单))]
        public async Task 设置角色可访问菜单(设置角色可访问菜单_Dto inputDto)
        {
            await domainService_Role.设置角色可访问菜单_DBAsync(inputDto.RoleId, inputDto.List_MenuId);
            await SaveAsync();
        }

        /// <summary>
        /// 修改角色名称时提供给后端的信息
        /// </summary>
        public class 修改角色名称_Dto
        {
            /// <summary>
            /// 需要修改的角色的Id
            /// </summary>
            [Required]
            public string RoleId { get; set; }

            /// <summary>
            /// 新的名称
            /// </summary>
            [Required]
            public string Name { get; set; }
        }

        /// <summary>
        /// 查询角色列表时提供给后端的查询条件
        /// </summary>
        public class 查询角色列表_Dto
        {
            /// <summary>
            /// 查询第几页
            /// </summary>
            public int PageIndex { get; set; } = 1;

            /// <summary>
            /// 每页显示多少条
            /// </summary>
            public int PageSize { get; set; } = 20;
        }

        /// <summary>
        /// 设置角色可访问菜单时提供给后端的信息
        /// </summary>
        public class 设置角色可访问菜单_Dto
        {
            /// <summary>
            /// 需要设施的角色的Id
            /// </summary>
            [Required]
            public string RoleId { get; set; }

            /// <summary>
            /// 此角色的可访问菜单的Id列表
            /// </summary>
            public List<string> List_MenuId { get; set; }
        }
    }
}