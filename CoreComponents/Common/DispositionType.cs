using System.ComponentModel;

namespace MES.Common
{
    /// <summary>
    /// 定义物料批的计划和物流配置或物料批的组装。
    /// 物料批处置的定义值是
    ///     已计划的:一个物理上还不存在的物料批次，被分配给操作请求(分段要求)或工作请求(第4部分对象)或作业订单(第4部分对象);
    ///     在加工中:物料批次正在加工中;
    ///     受限制:由于限制条件，一个物料批次不允许正常使用。
    ///         一个物料批次可能正在等待质量决定，或者物料批次在物理上是不可访问的。
    ///     不受限制:材料批次允许正常使用，不受限制;和
    ///     已结清:材料批已被核对为已完全消耗、出售或处理。
    /// </summary>
    public enum DispositionType
    {
        /// <summary>
        /// 已计划的
        /// </summary>
        [Description("已计划的")]
        已计划的,
        /// <summary>
        /// 在加工中
        /// </summary>
        [Description("在加工中")]
        在加工中,
        /// <summary>
        /// 受限制
        /// </summary>
        [Description("受限制")]
        受限制,
        /// <summary>
        /// 不受限制
        /// </summary>
        [Description("不受限制")]
        不受限制,
        /// <summary>
        /// 已结清
        /// </summary>
        [Description("已结清")]
        已结清,
        /// <summary>
        /// 其他
        /// </summary>
        [Description("其他")]
        其他
    }
}
