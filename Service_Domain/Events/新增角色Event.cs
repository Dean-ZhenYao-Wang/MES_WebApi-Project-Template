using BaseDB;
using MediatR;

namespace Service_Domain
{
    public class 新增角色Event : INotification
    {
        public 角色 新增角色 { get; }

        public 新增角色Event(角色 新增角色)
        {
            this.新增角色 = 新增角色;
        }
    }
}