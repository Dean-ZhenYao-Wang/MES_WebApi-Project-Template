using MediatR;
using System;

namespace Service_Domain
{
    public class 修改密码Event : INotification
    {
        public 修改密码Event(Guid accountId, string passWord)
        {
            AccountId = accountId;
            PassWord = passWord;
        }

        public Guid AccountId { get; }
        public string PassWord { get; }
    }
}