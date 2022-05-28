using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;

namespace MES
{
    public abstract class 字段
    {
        public string 名称 { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public string 字段类型 => GetType().Name;

        /// <summary>
        /// 字段的说明
        /// </summary>
        public string 说明 { get; set; }

        public object 值 { get; set; }

        [JsonIgnore]
        public Type 值的类型 => 值.GetType();
    }
}