using BaseDB;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Service_Domain.EventHandlers
{
    public class 修改角色名称EventHandler : INotificationHandler<修改角色名称Event>
    {
        private readonly SingletonObjectContext singletonObjectContext;

        public 修改角色名称EventHandler(SingletonObjectContext singletonObjectContext)
        {
            this.singletonObjectContext = singletonObjectContext;
        }
        public Task Handle(修改角色名称Event notification, CancellationToken cancellationToken)
        {
            singletonObjectContext.角色.First(m => m.Key == notification.RoleId).Id = notification.Name;
            return Task.FromResult(true);
        }
    }
}
