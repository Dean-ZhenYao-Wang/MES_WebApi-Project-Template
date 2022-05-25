using System.ComponentModel;

namespace MES.Common
{
    /// <summary>
    /// 定义了ISA 95中定义的基于角色的设备层次结构级别。
    /// 定义的值是。
    ///     企业
    ///     站点
    ///     地区
    ///     工作中心
    ///     工作单位
    ///     流程单元
    ///     单位
    ///     生产线
    ///     工作单元
    ///     生产单元
    ///     储存区
    ///     储存单元
    ///     设备模块
    ///     控制模块
    /// </summary>
    public enum EquipmentLevelType
    {
        /// <summary>
        /// 企业
        /// </summary>
        [Description("企业")]
        企业,
        /// <summary>
        /// 站点
        /// </summary>
        [Description("站点")]
        站点,
        /// <summary>
        /// 地区
        /// </summary>
        [Description("地区")]
        地区,
        /// <summary>
        /// 工作中心
        /// </summary>
        [Description("工作中心")]
        工作中心,
        /// <summary>
        /// 工作单位
        /// </summary>
        [Description("工作单位")]
        工作单位,
        /// <summary>
        /// 流程单元
        /// </summary>
        [Description("流程单元")]
        流程单元,
        /// <summary>
        /// 单位
        /// </summary>
        [Description("单位")]
        单位,
        /// <summary>
        /// 生产线
        /// </summary>
        [Description("生产线")]
        生产线,
        /// <summary>
        /// 工作单元
        /// </summary>
        [Description("工作单元")]
        工作单元,
        /// <summary>
        /// 生产单元
        /// </summary>
        [Description("生产单元")]
        生产单元,
        /// <summary>
        /// 储存区
        /// </summary>
        [Description("储存区")]
        储存区,
        /// <summary>
        /// 储存单元
        /// </summary>
        [Description("储存单元")]
        储存单元,
        /// <summary>
        /// 设备模块
        /// </summary>
        [Description("设备模块")]
        设备模块,
        /// <summary>
        /// 控制模块
        /// </summary>
        [Description("控制模块")]
        控制模块,
        /// <summary>
        /// 其他
        /// </summary>
        [Description("其他")]
        其他
    }
}
