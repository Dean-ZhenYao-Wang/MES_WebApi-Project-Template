using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository_DB
{
    public partial class EntityFrameworkRepository<T>
    {
        public async Task AddAsync(T entity)
        {

            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            await objectSet.AddAsync(entity);
        }
        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await objectSet.AddRangeAsync(entities);
        }
    }
}
