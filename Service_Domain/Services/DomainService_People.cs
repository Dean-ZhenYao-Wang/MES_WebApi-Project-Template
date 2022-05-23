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
    public class DomainService_People : IDomainService_People
    {
        private readonly IRepository<用户> 用户;
        private readonly IRepository<用户_组织> 用户所属组织;
        private readonly IRepository<用户_角色> 用户与角色间的构成关系;

        public DomainService_People(IUnitOfWork unitOfWork)
        {
            this.用户 = unitOfWork.用户;
            this.用户所属组织 = unitOfWork.用户_组织s;
            this.用户与角色间的构成关系 = unitOfWork.用户_角色s;
        }

        public async Task<用户> 新增用户_DBAsync(string accountNumber, string name, List<Guid> list_OrgId, List<Guid> list_RoleId)
        {
            BaseDB.用户 people = new 用户
            {
                Key = Guid.NewGuid(),
                登录用户名 = accountNumber,
                昵称=name,
                密码="123456",
            };
            people.记录创建人及创建时间();
            await 用户.AddAsync(people);
            if (list_OrgId != null && list_OrgId.Any())
            {
                List<BaseDB.用户_组织> people_X_Organizations = new List<BaseDB.用户_组织>();
                list_OrgId.ForEach(orgId =>
                        {
                            var p_x_o = new BaseDB.用户_组织
                            {
                                Key = Guid.NewGuid(),
                                用户Key = people.Key,
                                组织Key = orgId
                            };
                            p_x_o.记录创建人及创建时间();
                            people_X_Organizations.Add(p_x_o);
                        });
                await 用户所属组织.AddRangeAsync(people_X_Organizations);
            }
            if (list_RoleId != null && list_RoleId.Any())
            {
                List<BaseDB.用户_角色> people_X_Roles = new List<BaseDB.用户_角色>();
                list_RoleId.ForEach(roleId =>
                        {
                            var p_x_r = new BaseDB.用户_角色
                            {
                                Key = Guid.NewGuid(),
                                用户Key = people.Key,
                                角色Key = roleId
                            };
                            p_x_r.记录创建人及创建时间();
                            people_X_Roles.Add(p_x_r);
                        });

                await 用户与角色间的构成关系.AddRangeAsync(people_X_Roles);
            }
            return people;
        }

        public async Task 删除用户_DBAsync(List<Guid> listPeopleId)
        {
            var listPeople = await 用户.All().Where(m => listPeopleId.Contains(m.Key)).ToListAsync();
            listPeople.ForEach(m =>
            {
                m.删除();
            });
        }

        public async Task<PagedList<用户>> 查询用户列表_DBAsync(int pageIndex, int pageSize, bool? isDelete = null)
        {
            return await 用户.All()
                .Where(m => isDelete == null || m.IsDelete == isDelete)
                .Select(m => new 用户
                {
                    Key = m.Key,
                    昵称 = m.昵称,
                    性别=m.性别,
                    邮件=m.邮件,
                    手机=m.手机,
                    Code=m.Code,
                    头像=m.头像,
                    年龄=m.年龄,
                    生日=m.生日,
                    所属的组织列表 = m.所属的组织列表.Where(m => m.IsDelete == false).ToList(),
                    拥有的角色列表 = m.拥有的角色列表.Where(o => o.IsDelete == false).ToList(),
                    CreateDate = m.CreateDate,
                    CreateUser = m.CreateUser,
                    UpdateDate = m.UpdateDate,
                    UpdateUser = m.UpdateUser
                })
                .ToPagedListAsync(pageIndex, pageSize);
        }

        public async Task 修改用户信息_DBAsync(Guid peopleId, string accountNumber, string passWord, string name, List<Guid> list_OrgId = null, List<Guid> list_RoleId = null)
        {
            var people = await 用户.All().Where(m => m.Key == peopleId).FirstAsync();
            people.修改用户信息(accountNumber, passWord, name, list_OrgId, list_RoleId);
        }

    }
}