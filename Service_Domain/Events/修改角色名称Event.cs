using MediatR;
using System;

namespace Service_Domain
{
    public class 修改角色名称Event : INotification
    {
        public Guid RoleId { get; }
        public string Name { get; }

        public 修改角色名称Event(Guid roleId, string name)
        {
            this.RoleId = roleId;
            this.Name = name;
        }
    }
}