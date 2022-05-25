using System.ComponentModel;

namespace MES.Common
{
    /// <summary>
    /// 定义功能的类型。
    /// 定义的值
    ///     承诺:承诺供未来生产使用的能力;
    ///     无法达到的能力:由于设备条件、设备利用率、人员或材料的可用性而无法达到将来生产使用的能力;
    ///     可用:将来可用于其他生产用途的能力;
    ///     使用值:一个历史值，定义容量中质量可接受的部分;
    ///     未使用:定义容量未使用或质量不可接受的部分的历史值;和
    ///     总量:已使用和未使用能力的总和，或可用的、不可达到的和已承诺的能力的总和。
    /// </summary>
    public enum CapabilityTypeType
    {
        /// <summary>
        /// 承诺
        /// </summary>
        [Description("承诺")]
        承诺,
        /// <summary>
        /// 无法达到的能力
        /// </summary>
        [Description("无法达到的能力")]
        无法达到的能力,
        /// <summary>
        /// 可用
        /// </summary>
        [Description("可用")]
        可用,
        /// <summary>
        /// 使用值
        /// </summary>
        [Description("使用值")]
        使用值,
        /// <summary>
        /// 未使用
        /// </summary>
        [Description("未使用")]
        未使用,
        /// <summary>
        /// 总量
        /// </summary>
        [Description("总量")]
        总量,
        /// <summary>
        /// 其他
        /// </summary>
        [Description("其他")]
        其他
    }
}
