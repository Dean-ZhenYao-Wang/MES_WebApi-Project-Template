﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IRepository_DB
{
    public partial interface IRepository<T>
    {
        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entities);
    }
}
