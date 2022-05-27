using System.Threading.Tasks;

namespace IRepository_DB
{
    public partial interface IUnitOfWork
    {
        Task SaveAsync();
    }
}