using System.Collections.Generic;
using System.Text;

namespace MES.CoreComponents
{
    /// <summary>
    /// 用于任何枚举字符串的代码类型
    /// </summary>
    public class CodeType
    {
        public KeyValuePair<int, string> 值 { get; set; }

        public CodeType(KeyValuePair<int, string> 值, SelectionList 选项清单 = null) 
        {
            this.值 = 值;
            this.选项清单 = 选项清单;
        }

        public SelectionList 选项清单 { get; set; }
    }

}
