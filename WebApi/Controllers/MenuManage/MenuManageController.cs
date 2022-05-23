using BaseDB;
using IRepository_DB;
using IService_Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace WebApi.Controllers.MenuManage
{
    /// <summary>
    /// 菜单管理
    /// </summary>
    public class MenuManageController : BaseController
    {
        private readonly IDomainService_Menu domainService_Menu;

        /// <summary>
        /// 构造函数
        /// </summary>
        public MenuManageController(IDomainService_Menu domainService_Menu, IUnitOfWork unitOfWork, IMediator mediator) : base(unitOfWork, mediator)
        {
            this.domainService_Menu = domainService_Menu;
        }

        /// <summary>
        /// 新增菜单
        /// </summary>
        /// <param name="inputDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route(nameof(Add))]
        public async Task Add(Add_Dto inputDto)
        {
            await domainService_Menu.新增菜单_DBAsync(inputDto.Name, inputDto.Url, inputDto.编号, inputDto.序号, inputDto.ICON, inputDto.上级菜单Id);
            await SaveAsync();
        }

        /// <summary>
        /// 修改菜单
        /// </summary>
        /// <param name="inputDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route(nameof(Update))]
        public async Task Update(Update_Dto inputDto)
        {
            await domainService_Menu.修改菜单_DBAsync(inputDto.Id, inputDto.Name, inputDto.Url, inputDto.编号, inputDto.序号, inputDto.ICON, inputDto.上级菜单Id);
            await SaveAsync();
        }

        /// <summary>
        /// 删除菜单
        /// </summary>
        /// <param name="menuId">需要被删除的菜单的Id</param>
        /// <returns></returns>
        [HttpPost]
        [Route(nameof(Delete) + "/{menuId}")]
        public async Task Delete(Guid menuId)
        {
            await domainService_Menu.删除菜单_DBAsync(menuId);
            await SaveAsync();
        }

        /// <summary>
        /// 获取菜单树列表
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<菜单>> Get()
        {
            return await domainService_Menu.获取菜单列表_DBAsync();
        }

        /// <summary>
        /// 增加菜单时提供给后端的信息
        /// </summary>
        public class Add_Dto
        {
            /// <summary>
            /// 菜单名称
            /// </summary>
            [Required]
            public string Name { get; set; }

            /// <summary>
            /// 页面Url
            /// </summary>
            [Required]
            public string Url { get; set; }

            /// <summary>
            /// 辅助前端进行权限控制的一个编号
            /// </summary>
            public string 编号 { get; set; }

            /// <summary>
            /// 序号，用来进行排序用的，排序规则为升序
            /// </summary>
            public int 序号 { get; set; }

            /// <summary>
            /// 辅助前端进行菜单ICON的控制的
            /// </summary>
            public string ICON { get; set; }

            /// <summary>
            /// 父级菜单的Id 可为空
            /// </summary>
            public Guid? 上级菜单Id { get; set; }
        }

        /// <summary>
        /// 修改菜单时提供给后端的信息
        /// </summary>
        public class Update_Dto
        {
            /// <summary>
            /// 菜单Id
            /// </summary>
            [Required]
            public Guid Id { get; set; }

            /// <summary>
            /// 菜单名称
            /// </summary>
            [Required]
            public string Name { get; set; }

            /// <summary>
            /// 页面URL
            /// </summary>
            public string Url { get; set; }

            /// <summary>
            /// 辅助前端进行权限控制的一个编号
            /// </summary>
            public string 编号 { get; set; }

            /// <summary>
            /// 序号，用来进行排序用的，排序规则为升序
            /// </summary>
            public int 序号 { get; set; }

            /// <summary>
            /// 辅助前端进行菜单ICON的控制的
            /// </summary>
            public string ICON { get; set; }

            /// <summary>
            /// 父级菜单的Id 可为空
            /// </summary>
            public Guid? 上级菜单Id { get; set; }
        }
    }
}