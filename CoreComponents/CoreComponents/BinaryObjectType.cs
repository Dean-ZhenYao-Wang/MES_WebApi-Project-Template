using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Text;

namespace MES.CoreComponents
{
    /// <summary>
    /// 用于任何需要一组有限长度的八位元序列的元素的类型
    /// </summary>
    public struct BinaryObjectType
    {
        public string 值 { get; set; }

        public BinaryObjectType(string 值, string 格式 = null, string mime代码 = null, string 编码的代码 = null, string 字符集代码 = null, Uri uri = null, string 文件名 = null) : this()
        {
            this.值 = 值;
            this.格式 = 格式;
            Mime代码 = mime代码;
            this.编码的代码 = 编码的代码;
            this.字符集代码 = 字符集代码;
            Uri = uri;
            this.文件名 = 文件名;
        }

        /// <summary>
        /// 可选
        /// </summary>
        public string 格式 { get; set; }
        /// <summary>
        /// 可选
        /// </summary>
        public string Mime代码 { get; set; }
        /// <summary>
        /// 可选
        /// </summary>
        public string 编码的代码 { get; set; }
        /// <summary>
        /// 可选
        /// </summary>
        public string 字符集代码 { get; set; }
        /// <summary>
        /// 可选
        /// </summary>
        public Uri Uri { get; set; }
        /// <summary>
        /// 可选
        /// </summary>
        public string 文件名 { get; set; }
    }
}
