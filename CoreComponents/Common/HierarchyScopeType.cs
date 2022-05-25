using MES.CoreComponents;
using Microsoft.EntityFrameworkCore;

namespace MES.Common
{
    /// <summary>
    /// 层次范围确定了所交换的信息在基于角色的设备层次结构中的位置。
    /// 它定义了所交换的信息的范围，如与信息有关的站点或区域。
    /// 层次结构范围确定了基于角色的设备层次结构中的相关实例。
    /// </summary>
    [Owned]
    public partial class HierarchyScopeType
    {
        public EquipmentLevelType 设备元素级别 { get; set; }

        public EquipmentLevelType 设备级别 { get; set; }

        public HierarchyScopeType(EquipmentLevelType 设备元素级别, EquipmentLevelType 设备级别, IdentifierType 设备ID = null, HierarchyScopeType 层次结构范围子项 = null)
        {
            this.设备元素级别 = 设备元素级别;
            this.设备级别 = 设备级别;
            this.设备ID = 设备ID;
            this.层次结构范围子项 = 层次结构范围子项;
        }

        public HierarchyScopeType()
        {
        }

        public IdentifierType 设备ID { get; set; }
        public HierarchyScopeType 层次结构范围子项 { get; set; }
    }
}
