using System;
using System.Collections.Generic;
using System.Text;

namespace MES.CoreComponents
{
    /// <summary>
    /// 用于任何需要货币单位的元素
    /// </summary>
    public struct AmountType
    {
        public decimal 值 { get; set; }

        public AmountType(decimal 值, string 币别代号 = null, string 货币代码列表版本id = null) : this()
        {
            this.值 = 值;
            this.币别代号 = 币别代号;
            this.货币代码列表版本id = 货币代码列表版本id;
        }

        /// <summary>
        /// 可选
        /// </summary>
        public string 币别代号 { get; set; }
        /// <summary>
        /// 可选
        /// </summary>
        public string 货币代码列表版本id { get; set; }
    }
}
