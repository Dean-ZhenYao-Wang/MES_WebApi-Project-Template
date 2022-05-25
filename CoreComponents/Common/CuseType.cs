using MES.CoreComponents;
using System.Collections.Generic;

namespace MES.Common
{
    public class CuseType : CodeType
    {
        public CuseType(KeyValuePair<int, string> 值, SelectionList 选项清单 = null) : base(值, 选项清单)
        {
        }
    }
}
