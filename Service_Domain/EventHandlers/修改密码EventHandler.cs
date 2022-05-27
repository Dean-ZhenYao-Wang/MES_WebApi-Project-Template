using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Service_Domain.EventHandlers
{
    public class 修改密码EventHandler : INotificationHandler<修改密码Event>
    {
        public 修改密码EventHandler()
        {
        }

        public Task Handle(修改密码Event notification, CancellationToken cancellationToken)
        {
            return Task.FromResult(true);
        }
    }
}