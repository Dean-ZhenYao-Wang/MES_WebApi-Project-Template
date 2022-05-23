using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using IRepository_DB;
using System.Threading.Tasks;

namespace Repository_DB
{
    public partial class EntityFrameworkUnitOfWork
    {
        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
