using System.ComponentModel;

namespace MES.Common
{
    /// <summary>
    /// 定义工作单的状态，如ISA 95和ISA 88所定义。
    /// 定义的值是
    ///     等待中
    ///     待定
    ///     被取消
    ///     已发送
    ///     准备就绪
    ///     运行中
    ///     已完成
    ///     中止
    ///     保持中
    ///     暂停的
    ///     关闭
    /// </summary>
    public enum JobOrderDispatchStatusType
    {
        /// <summary>
        /// 等待中
        /// </summary>
        [Description("等待中")]
        等待中,
        /// <summary>
        /// 待定
        /// </summary>
        [Description("待定")]
        待定,
        /// <summary>
        /// 被取消
        /// </summary>
        [Description("被取消")]
        被取消,
        /// <summary>
        /// 已发送
        /// </summary>
        [Description("已发送")]
        已发送,
        /// <summary>
        /// 准备就绪
        /// </summary>
        [Description("准备就绪")]
        准备就绪,
        /// <summary>
        /// 运行中
        /// </summary>
        [Description("运行中")]
        运行中,
        /// <summary>
        /// 已完成
        /// </summary>
        [Description("已完成")]
        已完成,
        /// <summary>
        /// 中止
        /// </summary>
        [Description("中止")]
        中止,
        /// <summary>
        /// 保持中
        /// </summary>
        [Description("保持中")]
        保持中,
        /// <summary>
        /// 暂停的
        /// </summary>
        [Description("暂停的")]
        暂停的,
        /// <summary>
        /// 关闭
        /// </summary>
        [Description("关闭")]
        关闭,
        /// <summary>
        /// 其他
        /// </summary>
        [Description("其他")]
        其他
    }
}
