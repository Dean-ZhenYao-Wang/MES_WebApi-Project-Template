using System.ComponentModel;

namespace MES.Common
{
    /// <summary>
    /// 定义了操作事件发布者的MOM功能。
    /// 第三部分MOM活动模型的定义值是
    /// 资源管理、定义管理、详细调度、派遣、执行管理、数据收集、性能分析、跟踪
    /// </summary>
    public enum MOMFunctionType
    {
        /// <summary>
        /// 资源管理
        /// </summary>
        [Description("资源管理")]
        资源管理,
        /// <summary>
        /// 定义管理
        /// </summary>
        [Description("定义管理")]
        定义管理,
        /// <summary>
        /// 详细调度
        /// </summary>
        [Description("详细调度")]
        详细调度,
        /// <summary>
        /// 派遣
        /// </summary>
        [Description("派遣")]
        派遣,
        /// <summary>
        /// 执行管理
        /// </summary>
        [Description("执行管理")]
        执行管理,
        /// <summary>
        /// 数据收集
        /// </summary>
        [Description("数据收集")]
        数据收集,
        /// <summary>
        /// 性能分析
        /// </summary>
        [Description("性能分析")]
        性能分析,
        /// <summary>
        /// 跟踪
        /// </summary>
        [Description("跟踪")]
        跟踪,
        /// <summary>
        /// 其他
        /// </summary>
        [Description("其他")]
        其他
    }
}
