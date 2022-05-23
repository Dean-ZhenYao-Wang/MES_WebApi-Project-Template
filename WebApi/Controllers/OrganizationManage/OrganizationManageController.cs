using BaseDB;
using IRepository_DB;
using IService_Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace WebApi.Controllers.OrganizationManage
{
    /// <summary>
    /// 组织管理
    /// </summary>
    public class OrganizationManageController : BaseController
    {
        private readonly IDomainService_Organization domainService_Organization;
        /// <summary>
        /// 构造函数
        /// </summary>
        public OrganizationManageController(IDomainService_Organization domainService_Organization, IUnitOfWork unitOfWork, IMediator mediator) : base(unitOfWork, mediator)
        {
            this.domainService_Organization = domainService_Organization;
        }

        /// <summary>
        /// 新增组织
        /// </summary>
        /// <param name="inputDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route(nameof(新增组织))]
        public async Task 新增组织(新增组织_Dto inputDto)
        {
            await domainService_Organization.新增组织_DBAsync(inputDto.编号, inputDto.序号, inputDto.名称, inputDto.全名, inputDto.上一级组织的Id);
            await SaveAsync();
        }

        /// <summary>
        /// 删除组织
        /// </summary>
        /// <param name="orgId"></param>
        /// <returns></returns>
        [HttpPost]
        [Route(nameof(删除组织) + "/{orgId}")]
        public async Task 删除组织(Guid orgId)
        {
            await domainService_Organization.删除组织_DBAsync(orgId);
            await SaveAsync();
        }

        /// <summary>
        /// 修改组织
        /// </summary>
        /// <param name="inputDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route(nameof(修改组织))]
        public async Task 修改组织(修改组织_Dto inputDto)
        {
            await domainService_Organization.修改组织_DBAsync(inputDto.OrgId,inputDto.编号,inputDto.序号,inputDto.名称, inputDto.全名, inputDto.上一级组织的Id);
            await SaveAsync();
        }

        /// <summary>
        /// 获取组织树
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<List<组织>> 获取组织树()
        {
            return await domainService_Organization.获取组织树_DBAsync();
        }

        /// <summary>
        /// 新增组织时提供给后端的信息
        /// </summary>
        public class 新增组织_Dto
        {
            [Required]
            public string 名称 { get; set; }
            [Required]
            public string 全名 { get; set; }
            [Required]
            public string 编号 { get; set; }
            [Required]
            public int 序号 { get; set; }

            /// <summary>
            /// 父级组织的Id 可为空
            /// </summary>
            public Guid? 上一级组织的Id { get; set; }
        }

        /// <summary>
        /// 修改组织时提供给后端的信息
        /// </summary>
        public class 修改组织_Dto
        {
            /// <summary>
            /// 组织Id
            /// </summary>
            [Required]
            public Guid OrgId { get; set; }


            [Required]
            public string 名称 { get; set; }
            [Required]
            public string 全名 { get; set; }
            [Required]
            public string 编号 { get; set; }
            [Required]
            public int 序号 { get; set; }

            /// <summary>
            /// 父级组织的Id 可为空
            /// </summary>
            public Guid? 上一级组织的Id { get; set; }
        }
    }
}