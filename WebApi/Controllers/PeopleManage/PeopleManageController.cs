using BaseDB;
using IRepository_DB;
using IService_Domain;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Service_Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Util.Model;

namespace WebApi.Controllers.PeopleManage
{
    /// <summary>
    /// 用户管理
    /// </summary>
    public class PeopleManageController : BaseController
    {
        private readonly IDomainService_People domainService_People;

        /// <summary>
        /// 构造函数
        /// </summary>
        public PeopleManageController(IDomainService_People domainService_People, IUnitOfWork unitOfWork, IMediator mediator) : base(unitOfWork, mediator)
        {
            this.domainService_People = domainService_People;
        }

        /// <summary>
        /// 新增用户
        /// </summary>
        /// <param name="inputDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route(nameof(新增用户))]
        public async Task 新增用户(新增用户_Dto inputDto)
        {
            用户 people;
            people = await domainService_People.新增用户_DBAsync(inputDto.AccountNumber, inputDto.Name, inputDto.List_OrgId, inputDto.List_RoleId);
            await SaveAsync();
            await Publish(new 新增用户Event(people));
        }

        /// <summary>
        /// 删除用户
        /// </summary>
        /// <param name="listPeopleId">所有需要被删除的用户的Id所组成的列表</param>
        /// <returns></returns>
        [HttpPost]
        [Route(nameof(删除用户))]
        public async Task 删除用户(List<string> listPeopleId)
        {
            await domainService_People.删除用户_DBAsync(listPeopleId);
            await SaveAsync();
            await Publish(new 删除用户Event(listPeopleId));
        }

        /// <summary>
        /// 修改用户信息
        /// </summary>
        /// <param name="inputDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route(nameof(修改用户信息))]
        public async Task 修改用户信息(修改用户信息_Dto inputDto)
        {
            await domainService_People.修改用户信息_DBAsync(inputDto.PeopleId, inputDto.AccountNumber, inputDto.PassWord, inputDto.Name, inputDto.List_OrgId, inputDto.List_RoleId);
            await SaveAsync();
        }

        /// <summary>
        /// 查询用户列表
        /// 此处返回类型还需在此处再次转换成VO
        /// </summary>
        /// <param name="inputDto"></param>
        /// <returns></returns>
        [HttpPost]
        [Route(nameof(查询用户列表))]
        public async Task<PagedList<用户>> 查询用户列表(查询用户列表_Dto inputDto)
        {
            return await domainService_People.查询用户列表_DBAsync(inputDto.PageIndex, inputDto.PageSize, inputDto.IsDelete);
        }

        /// <summary>
        /// 新增用户时提供给后端的信息
        /// </summary>
        public class 新增用户_Dto
        {
            /// <summary>
            /// 用户的登录账号
            /// </summary>
            [Required]
            public string AccountNumber { get; set; }

            /// <summary>
            /// 姓名
            /// </summary>
            [Required]
            public string Name { get; set; }

            /// <summary>
            /// 所属组织的Id列表
            /// </summary>
            public List<string> List_OrgId { get; set; }

            /// <summary>
            /// 拥有的角色的Id列表
            /// </summary>
            public List<string> List_RoleId { get; set; }
        }

        /// <summary>
        /// 修改用户信息时提供给后端的数据
        /// </summary>
        public class 修改用户信息_Dto
        {
            /// <summary>
            /// 被修改人的Id
            /// </summary>
            [Required]
            public string PeopleId { get; set; }

            /// <summary>
            /// 登录账号
            /// </summary>
            [Required]
            public string AccountNumber { get; set; }

            /// <summary>
            /// 姓名
            /// </summary>
            [Required]
            public string Name { get; set; }

            /// <summary>
            /// 密码
            /// </summary>
            [Required]
            public string PassWord { get; set; }

            /// <summary>
            /// 所属组织的Id列表
            /// </summary>
            public List<string> List_OrgId { get; set; }

            /// <summary>
            /// 拥有的角色的Id列表
            /// </summary>
            public List<string> List_RoleId { get; set; }
        }

        /// <summary>
        /// 查询用户列表时的查询条件
        /// </summary>
        public class 查询用户列表_Dto
        {
            /// <summary>
            /// 需要查询哪一页
            /// </summary>
            public int PageIndex { get; set; } = 1;

            /// <summary>
            /// 每页显示多少条数据
            /// </summary>
            public int PageSize { get; set; } = 20;

            /// <summary>
            /// 控制是否查询已删除用户的参数,可为空
            /// 为空时代表查询未删除的用户和已删除的用户
            /// true:仅查询已删除用户
            /// false:仅查询未删除用户
            /// </summary>
            public bool? IsDelete { get; set; }
        }
    }
}