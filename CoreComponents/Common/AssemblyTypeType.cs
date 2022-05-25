using System;
using System.ComponentModel;

namespace MES.Common
{
    /// <summary>
    /// 定义了装配的类型。
    /// 定义的类型有
    ///     物理的：装配体的组件是物理连接的或在同一区域。
    ///     逻辑的：装配体的组件不一定在物理上连接或在同一区域内。
    /// </summary>
    public enum AssemblyTypeType
    {
        /// <summary>
        /// 物理
        /// </summary>
        [Description("物理")]
        物理,
        /// <summary>
        /// 逻辑
        /// </summary>
        [Description("逻辑")]
        逻辑,
        /// <summary>
        /// 其他
        /// </summary>
        [Description("其他")]
        其他
    }
}
