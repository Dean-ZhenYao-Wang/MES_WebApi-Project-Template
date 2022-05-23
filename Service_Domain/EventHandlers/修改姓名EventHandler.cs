using BaseDB;
using MediatR;
using Service_Domain.Events;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Service_Domain.EventHandlers
{
    public class 修改姓名EventHandler : INotificationHandler<修改姓名Event>
    {
        private readonly SingletonObjectContext singletonObjectContext;

        public 修改姓名EventHandler(SingletonObjectContext singletonObjectContext)
        {
            this.singletonObjectContext = singletonObjectContext;
        }

        public Task Handle(修改姓名Event notification, CancellationToken cancellationToken)
        {
            var people = singletonObjectContext.用户特性
                .First(m => m.IsDelete == false && m.构成的用户_Key == notification.Key && m.Id.Equals("Name"));
            people.值 = notification.Name;
            return Task.FromResult(true);
        }
    }
}
