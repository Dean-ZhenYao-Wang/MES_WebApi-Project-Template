using MediatR;
using System;

namespace Service_Domain.Events
{
    public class 修改姓名Event : INotification
    {

        public 修改姓名Event(Guid key, string name)
        {
            Key = key;
            Name = name;
        }

        public Guid Key { get; }
        public string Name { get; }
    }
}