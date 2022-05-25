using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MES.CoreComponents
{
    /// <summary>
    /// 用于任何日期和/或时间表示
    /// </summary>
    [Owned]
    public class DateTimeType 
    {
        public DateTime 值 { get; set; }

        public DateTimeType(DateTime 值, string 格式 = null)
        {
            this.值 = 值;
            this.格式 = 格式;
        }

        /// <summary>
        /// 可选
        /// </summary>
        public string 格式 { get; set; }
    }
}
