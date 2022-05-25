using System.ComponentModel;

namespace MES.Common
{
    /// <summary>
    /// 定义了物料类别、物料定义、物料批次或物料子批次在作业段范围内的预期用途。
    /// 生产业务的定义值是
    /// - 消耗品、消耗量、生产量、过程中副产品产量、副产品生产产量、产出的产量。
    /// 维修业务的定义值是
    /// - 消耗品、消耗的材料、生产的材料。
    /// 质量测试操作的定义值是
    /// - 消耗品、破坏性样品、退回的样品、保留的样品。
    /// 库存操作的定义值是
    /// - 消耗品、消耗的材料、生产的材料、存货。
    /// </summary>
    public enum MaterialUseType
    {
        /// <summary>
        /// 消耗品
        /// </summary>
        [Description("消耗品")]
        消耗品,
        /// <summary>
        /// 消耗量
        /// </summary>
        [Description("消耗量")]
        消耗量,
        /// <summary>
        /// 生产量
        /// </summary>
        [Description("生产量")]
        生产量,
        /// <summary>
        /// 过程中副产品产量
        /// </summary>
        [Description("过程中副产品产量")]
        过程中副产品产量,
        /// <summary>
        /// 副产品生产产量
        /// </summary>
        [Description("副产品生产产量")]
        副产品生产产量,
        /// <summary>
        /// 产出的产量
        /// </summary>
        [Description("产出的产量")]
        产出的产量,
        /// <summary>
        /// 消耗的材料
        /// </summary>
        [Description("消耗的材料")]
        消耗的材料,
        /// <summary>
        /// 生产的材料
        /// </summary>
        [Description("生产的材料")]
        生产的材料,
        /// <summary>
        /// 破坏性样品
        /// </summary>
        [Description("破坏性样品")]
        破坏性样品,
        /// <summary>
        /// 其他
        /// </summary>
        [Description("退回的样品")]
        退回的样品,
        /// <summary>
        /// 保留的样品
        /// </summary>
        [Description("保留的样品")]
        保留的样品,
        /// <summary>
        /// 存货
        /// </summary>
        [Description("存货")]
        存货,
        /// <summary>
        /// 其他
        /// </summary>
        [Description("其他")]
        其他
    }
}
