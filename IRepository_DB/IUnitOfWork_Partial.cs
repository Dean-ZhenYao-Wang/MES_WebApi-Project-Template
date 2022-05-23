using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace IRepository_DB
{
    public partial interface IUnitOfWork
    {
        Task SaveAsync();
    }
}
