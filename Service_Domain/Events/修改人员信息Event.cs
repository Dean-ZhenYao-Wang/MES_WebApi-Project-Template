using MediatR;
using System;
using System.Collections.Generic;

namespace Service_Domain
{
    public class 修改用户信息Event : INotification
    {
        public 修改用户信息Event(Guid peopleId, string accountNumber, string passWord, string name, List<Guid> list_OrgId, List<Guid> list_RoleId)
        {
            PeopleId = peopleId;
            AccountNumber = accountNumber;
            PassWord = passWord;
            Name = name;
            List_OrgId = list_OrgId;
            List_RoleId = list_RoleId;
        }

        public Guid PeopleId { get; }
        public string AccountNumber { get; }
        public string PassWord { get; }
        public string Name { get; }
        public List<Guid> List_OrgId { get; }
        public List<Guid> List_RoleId { get; }
    }
}