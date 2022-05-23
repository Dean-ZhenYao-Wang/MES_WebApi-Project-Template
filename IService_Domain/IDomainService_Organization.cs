﻿using BaseDB;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IService_Domain
{
    public interface IDomainService_Organization
    {
        Task 新增组织_DBAsync(string 编号, int 序号, string 名称, string 全名, Guid? 上一级组织的Id);

        Task 删除组织_DBAsync(Guid orgId);

        Task 修改组织_DBAsync(Guid orgId, string 编号, int 序号, string 名称, string 全名, Guid? 上一级组织的Id);

        Task<List<组织>> 获取组织树_DBAsync();
    }
}