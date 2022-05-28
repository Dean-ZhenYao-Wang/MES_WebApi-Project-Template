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
        private readonly IRepository<PersonType> 用户;
        private readonly IRepository<用户_组织> 用户所属组织;

        public DomainService_People(IUnitOfWork unitOfWork)
        {
            用户 = unitOfWork.Peoples;
            用户所属组织 = unitOfWork.用户_组织s;
        }

        public async Task<PersonType> 新增用户_DBAsync(string accountNumber, string name, List<string> list_OrgId, List<string> list_RoleId)
        {
            PersonType people = new PersonType
            {
                Key = Guid.NewGuid().ToString(),
                登录用户名 = accountNumber,
                昵称 = name,
                密码 = "123456",
            };
            people.记录创建人及创建时间();
            await 用户.AddAsync(people);
            if (list_OrgId != null && list_OrgId.Any())
            {
                List<用户_组织> people_X_Organizations = new List<用户_组织>();
                list_OrgId.ForEach(orgId =>
                        {
                            var p_x_o = new 用户_组织
                            {
                                Key = Guid.NewGuid().ToString(),
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
                people.PersonnelClassID = new List<IdentifierType>();
                list_RoleId.ForEach(roleId =>
                        {
                            people.PersonnelClassID.Add(new IdentifierType
                            {
                                Value = roleId
                            });
                        });

            }
            return people;
        }

        public async Task 删除用户_DBAsync(List<string> listPeopleId)
        {
            var listPeople = await 用户.All().Where(m => listPeopleId.Contains(m.Key)).ToListAsync();
            listPeople.ForEach(m =>
            {
                m.删除();
            });
        }

        public async Task<PagedList<PersonType>> 查询用户列表_DBAsync(int pageIndex, int pageSize, bool? isDelete = null)
        {
            return await 用户.All()
                .Where(m => isDelete == null || m.IsDelete == isDelete)
                .Select(m => new PersonType
                {
                    Key = m.Key,
                    昵称 = m.昵称,
                    性别 = m.性别,
                    邮件 = m.邮件,
                    手机 = m.手机,
                    Code = m.Code,
                    头像 = m.头像,
                    年龄 = m.年龄,
                    生日 = m.生日,
                    所属的组织列表 = m.所属的组织列表.Where(m => m.IsDelete == false).ToList(),
                    CreateDate = m.CreateDate,
                    CreateUser = m.CreateUser,
                    UpdateDate = m.UpdateDate,
                    UpdateUser = m.UpdateUser
                })
                .ToPagedListAsync(pageIndex, pageSize);
        }

        public async Task 修改用户信息_DBAsync(string peopleId, string accountNumber, string passWord, string name, List<string> list_OrgId = null, List<string> list_RoleId = null)
        {
            var people = await 用户.All().Where(m => m.Key.Equals(peopleId)).FirstAsync();
            people.修改用户信息(accountNumber, passWord, name, list_OrgId, list_RoleId);
        }
    }
}