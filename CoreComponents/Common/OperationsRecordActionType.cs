using System.ComponentModel;

namespace MES.Common
{
    /// <summary>
    /// 允许发布者应用于操作记录模板中的操作记录条目模板对象的动作集。
    /// 动作的定义值是
    /// 添加、更改、删除、观察。
    /// 如果没有指定动作，这相当于允许所有动作。
    /// </summary>
    public enum OperationsRecordActionType
    {
        /// <summary>
        /// 添加
        /// </summary>
        [Description("添加")]
        添加,
        /// <summary>
        /// 更改
        /// </summary>
        [Description("更改")]
        更改,
        /// <summary>
        /// 删除
        /// </summary>
        [Description("删除")]
        删除,
        /// <summary>
        /// 观察
        /// </summary>
        [Description("观察")]
        观察,
        /// <summary>
        /// 其他
        /// </summary>
        [Description("其他")]
        其他
    }
}
