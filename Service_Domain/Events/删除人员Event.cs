using MediatR;
using System;
using System.Collections.Generic;

namespace Service_Domain
{
    public class 删除用户Event : INotification
    {
        public List<string> ListPeopleId { get; }

        public 删除用户Event(List<string> listPeopleId)
        {
            this.ListPeopleId = listPeopleId;
        }
    }
}