using BaseDB;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Service_Domain.EventHandlers
{
    public class 删除用户EventHandler : INotificationHandler<删除用户Event>
    {
        public 删除用户EventHandler()
        {
        }

        public Task Handle(删除用户Event notification, CancellationToken cancellationToken)
        {
            return Task.FromResult(true);
        }
    }
}
