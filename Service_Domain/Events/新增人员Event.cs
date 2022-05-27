using BaseDB;
using MediatR;

namespace Service_Domain
{
    public class 新增用户Event : INotification
    {
        public 用户 People { get; }

        public 新增用户Event(用户 people)
        {
            this.People = people;
        }
    }
}