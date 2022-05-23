using BaseDB;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Service_Domain.EventHandlers
{
    public class 新增角色EventHandler : INotificationHandler<新增角色Event>
    {
        private readonly SingletonObjectContext singletonObjectContext;

        public 新增角色EventHandler(SingletonObjectContext singletonObjectContext)
        {
            this.singletonObjectContext = singletonObjectContext;
        }
        public Task Handle(新增角色Event notification, CancellationToken cancellationToken)
        {
            singletonObjectContext.角色.Add(notification.新增角色);
            return Task.FromResult(true);
        }
    }
}
