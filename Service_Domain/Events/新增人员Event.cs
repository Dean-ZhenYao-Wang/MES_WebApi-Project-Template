using BaseDB;
using MediatR;

namespace Service_Domain
{
    public class 新增用户Event : INotification
    {
        public PersonType People { get; }

        public 新增用户Event(PersonType people)
        {
            People = people;
        }
    }
}