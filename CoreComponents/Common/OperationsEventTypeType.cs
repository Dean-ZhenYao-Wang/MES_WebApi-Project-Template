using System.ComponentModel;

namespace MES.Common
{
    /// <summary>
    /// 3级操作事件的类型。
    /// 定义的值是事件、警报、报警。
    /// 这个属性必须在相应的操作事件定义中定义。
    /// </summary>
    public enum OperationsEventTypeType
    {
        /// <summary>
        /// 事件
        /// </summary>
        [Description("事件")]
        事件,
        /// <summary>
        /// 警报
        /// </summary>
        [Description("警报")]
        警报,
        /// <summary>
        /// 报警
        /// </summary>
        [Description("报警")]
        报警,
        /// <summary>
        /// 其他
        /// </summary>
        [Description("其他")]
        其他

    }
}
