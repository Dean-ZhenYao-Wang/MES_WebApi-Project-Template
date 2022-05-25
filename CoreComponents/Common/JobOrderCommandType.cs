using System.ComponentModel;

namespace MES.Common
{
    /// <summary>
    /// 定义对工作单的命令，如ISA95和ISA88中定义的。
    /// 定义的值是。
    ///     开始
    ///     停止
    ///     保持
    ///     重新开始
    ///     中止
    ///     复位
    ///     暂停
    ///     恢复
    /// </summary>
    public enum JobOrderCommandType
    {
        /// <summary>
        /// 开始
        /// </summary>
        [Description("开始")]
        开始,
        /// <summary>
        /// 停止
        /// </summary>
        [Description("停止")]
        停止,
        /// <summary>
        /// 保持
        /// </summary>
        [Description("保持")]
        保持,
        /// <summary>
        /// 重新开始
        /// </summary>
        [Description("重新开始")]
        重新开始,
        /// <summary>
        /// 中止
        /// </summary>
        [Description("中止")]
        中止,
        /// <summary>
        /// 复位
        /// </summary>
        [Description("复位")]
        复位,
        /// <summary>
        /// 暂停
        /// </summary>
        [Description("暂停")]
        暂停,
        /// <summary>
        /// 恢复
        /// </summary>
        [Description("恢复")]
        恢复,
        /// <summary>
        /// 其他
        /// </summary>
        [Description("其他")]
        其他
    }
}
