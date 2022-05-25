using MES.CoreComponents;
using System;

namespace MES.Common
{
    /// <summary>
    /// 设备资产映射类型
    /// </summary>
    public partial class EquipmentAssetMappingType
    {
        public EquipmentAssetMappingType()
        {
        }

        public EquipmentAssetMappingType(IdentifierType 设备ID, IdentifierType 实物资产ID, HierarchyScopeType 层次结构范围, DateTimeType startTime, DateTimeType endTime, Guid key)
        {
            this.设备ID = 设备ID;
            this.实物资产ID = 实物资产ID;
            this.层次结构范围 = 层次结构范围;
            StartTime = startTime;
            EndTime = endTime;
            Key = key;
        }

        public IdentifierType 设备ID { get; set; }
        public IdentifierType 实物资产ID { get; set; }
        public HierarchyScopeType 层次结构范围 { get; set; }
        public DateTimeType StartTime { get; set; }
        public DateTimeType EndTime { get; set; }
    }
}
