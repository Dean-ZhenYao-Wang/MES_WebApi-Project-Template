using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MES.CoreComponents
{
    /// <summary>
    /// 用于标识一个元素的任意字符串
    /// </summary>
    [Owned]
    public class IdentifierType 
    {
        public string 值 { get; set; }

        public IdentifierType(string 值, string 方案ID = null, string 方案名称 = null, string 方案机构ID = null, string 方案机构名称 = null, string 方案版本ID = null, string 方案数据URI = null, string 方案URI = null) 
        {
            this.值 = 值;
            this.方案ID = 方案ID;
            this.方案名称 = 方案名称;
            this.方案机构ID = 方案机构ID;
            this.方案机构名称 = 方案机构名称;
            this.方案版本ID = 方案版本ID;
            this.方案数据URI = 方案数据URI;
            this.方案URI = 方案URI;
        }
        /// <summary>
        /// 可选
        /// </summary>
        public string 方案ID { get; set; }
        /// <summary>
        /// 可选
        /// </summary>
        public string 方案名称 { get; set; }
        /// <summary>
        /// 可选
        /// </summary>
        public string 方案机构ID { get; set; }
        /// <summary>
        /// 可选
        /// </summary>
        public string 方案机构名称 { get; set; }
        /// <summary>
        /// 可选
        /// </summary>
        public string 方案版本ID { get; set; }
        /// <summary>
        /// 可选
        /// </summary>
        public string 方案数据URI { get; set; }
        /// <summary>
        /// 可选
        /// </summary>
        public string 方案URI { get; set; }
    }
}
