using MES.CoreComponents;
using System.Collections.Generic;

namespace MES.Common
{
    /// <summary>
    /// 设备用途类型
    /// </summary>
    public class EquipmentUseType : CodeType
    {
        public EquipmentUseType(KeyValuePair<int, string> 值, SelectionList 选项清单 = null) : base(值, 选项清单)
        {
        }
    }
}
