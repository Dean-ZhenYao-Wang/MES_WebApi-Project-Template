using BaseDB;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Service_Domain.EventHandlers
{
    public class 新增用户EventHandler : INotificationHandler<新增用户Event>
    {
        public 新增用户EventHandler()
        {
        }

        public Task Handle(新增用户Event notification, CancellationToken cancellationToken)
        {
            return Task.FromResult(true);
        }
    }
}
