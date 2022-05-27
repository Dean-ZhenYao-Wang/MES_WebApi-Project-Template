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
    public class DomainService_Organization : IDomainService_Organization
    {
        private readonly IRepository<组织> 组织;
        private readonly IRepository<用户_组织> 用户所属组织;

        public DomainService_Organization(IUnitOfWork unitOfWork)
        {
            this.组织 = unitOfWork.组织;
            this.用户所属组织 = unitOfWork.用户_组织s;
        }

        public async Task 修改组织_DBAsync(string orgId, string 编号, int 序号, string 名称, string 全名, string 上一级组织的Id)
        {
            var org = await 组织.All().Where(m => m.Key.Equals(orgId)).FirstAsync();
            org.名称 = 名称;
            org.全名 = 名称;
            org.序号 = 序号;
            org.编号 = 编号;
            org.上级组织Key = 上一级组织的Id;
            org.记录修改人及修改时间();
        }

        public async Task 删除组织_DBAsync(string orgId)
        {
            var org = await 组织.All().Where(m => m.Key.Equals(orgId)).FirstAsync();
            org.删除();
            var listPeople = await 用户所属组织.All().Where(m => m.IsDelete == false && m.组织Key.Equals(orgId)).ToListAsync();
            listPeople.ForEach(m =>
            {
                m.删除();
            });
        }

        public async Task 新增组织_DBAsync(string 编号, int 序号, string 名称, string 全名, string 上一级组织的Id)
        {
            BaseDB.组织 org = new 组织
            {
                Key = Guid.NewGuid().ToString(),
                名称 = 名称,
                全名 = 名称,
                序号 = 序号,
                编号 = 编号,
                上级组织Key = 上一级组织的Id
            };
            org.记录创建人及创建时间();
            await 组织.AddAsync(org);
        }

        public async Task<List<组织>> 获取组织树_DBAsync()
        {
            var 顶级组织列表 = await 组织.All().Where(org => org.IsDelete == false)
                .Where(org => org.上级组织Key == null)
                .AsNoTracking()
                .ToListAsync();
            return 顶级组织列表;
        }
    }
}