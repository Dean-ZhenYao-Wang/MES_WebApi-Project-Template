using BaseDB;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Service_Domain.EventHandlers
{
    public class 修改用户信息EventHandler : INotificationHandler<修改用户信息Event>
    {
        private readonly SingletonObjectContext singletonObjectContext;

        public 修改用户信息EventHandler(SingletonObjectContext singletonObjectContext)
        {
            this.singletonObjectContext = singletonObjectContext;
        }

        public Task Handle(修改用户信息Event notification, CancellationToken cancellationToken)
        {
            var people = singletonObjectContext.用户.First(m => m.Key == notification.PeopleId);
            people.修改用户信息(notification.AccountNumber, notification.PassWord, notification.Name, notification.List_OrgId, notification.List_RoleId);
            return Task.FromResult(true);
        }
    }
}
