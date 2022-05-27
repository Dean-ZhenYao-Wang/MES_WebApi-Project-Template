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