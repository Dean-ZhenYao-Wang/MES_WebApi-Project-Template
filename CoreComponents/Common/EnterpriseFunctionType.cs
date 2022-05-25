using System.ComponentModel;

namespace MES.Common
{
    /// <summary>
    /// 定义操作事件发布者的企业功能。
    /// 第1部分功能模型中的定义值是
    /// 订单处理，作业调度，生产控制，材料和能源控制，
    /// 采购、质量保证、产品库存控制、产品成本核算、
    /// 产品运输管理，维护管理，市场和销售，研发和工程。
    /// </summary>
    public enum EnterpriseFunctionType
    {
        /// <summary>
        /// 订单处理
        /// </summary>
        [Description("订单处理")]
        订单处理,
        /// <summary>
        /// 作业调度
        /// </summary>
        [Description("作业调度")]
        作业调度,
        /// <summary>
        /// 生产控制
        /// </summary>
        [Description("生产控制")]
        生产控制,
        /// <summary>
        /// 材料和能源控制
        /// </summary>
        [Description("材料和能源控制")]
        材料和能源控制,
        /// <summary>
        /// 采购
        /// </summary>
        [Description("采购")]
        采购,
        /// <summary>
        /// 质量保证
        /// </summary>
        [Description("质量保证")]
        质量保证,
        /// <summary>
        /// 产品库存控制
        /// </summary>
        [Description("产品库存控制")]
        产品库存控制,
        /// <summary>
        /// 产品成本核算
        /// </summary>
        [Description("产品成本核算")]
        产品成本核算,
        /// <summary>
        /// 产品运输管理
        /// </summary>
        [Description("产品运输管理")]
        产品运输管理,
        /// <summary>
        /// 维护管理
        /// </summary>
        [Description("维护管理")]
        维护管理,
        /// <summary>
        /// 市场和销售
        /// </summary>
        [Description("市场和销售")]
        市场和销售,
        /// <summary>
        /// 研发和工程
        /// </summary>
        [Description("研发和工程")]
        研发和工程,
        /// <summary>
        /// 其他
        /// </summary>
        [Description("其他")]
        其他
    }
}
