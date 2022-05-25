using System.ComponentModel;

namespace MES.Common
{
    /// <summary>
    /// 定义在一个层次结构中包含相应的操作事件类的约束。
    /// 定义的值是
    /// -密封：没有条目可以使用此条目作为其父级。
    /// -NA：无条目允许任何条目代表此条目作为其父/母。
    /// 扩展可以包含一组其他操作事件类的条目，这些条目在其父级中代表这个条目。
    /// </summary>
    public enum OperationsEventExtensionType
    {
        /// <summary>
        /// 密封
        /// </summary>
        [Description("密封")]
        密封,
        /// <summary>
        /// NA
        /// </summary>
        [Description("NA")]
        NA,
        /// <summary>
        /// 其他
        /// </summary>
        [Description("其他")]
        其他
    }
}
