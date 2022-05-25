using MES.CoreComponents;
using System.ComponentModel;

namespace MES.Common
{
    /// <summary>
    /// 定义了关系的类型。
    /// 定义的类型有
    ///     永久性：不打算在生产过程中拆分的装配。
    ///     暂时性的：在生产过程中使用的临时装配，如不同材料的托盘或批量套件。
    /// </summary>
    public enum AssemblyRelationshipType
    {
        /// <summary>
        /// 永久
        /// </summary>
        [Description("永久")]
        永久 = 0,
        /// <summary>
        /// 暂时
        /// </summary>
        [Description("暂时")]
        暂时 = 1,
        /// <summary>
        /// 其他
        /// </summary>
        [Description("其他")]
        其他 = 2
    }
}
