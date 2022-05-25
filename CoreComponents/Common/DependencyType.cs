using System.ComponentModel;

namespace MES.Common
{
    /// <summary>
    /// 定义了两个元素的执行依赖约束。
    /// 定义的值是（用元素A和元素B之间的依赖类型解释）
    ///     开始时: 开始B在A开始时。
    ///     在开始之后: 在A开始后开始B。
    ///     结束后：在A结束后开始B。
    ///     不跟随：B不能跟随A。
    ///     可能并行：B可能与A平行。
    ///     不并行：B不得与A并行。
    ///     开始后不晚于：启动B不晚于A启动后的依存系数。
    ///     开始后不早于：启动B不早于A启动后的依存系数。
    ///     不晚于结束后：开始B不晚于A结束后的依存系数。
    ///     不早于结束后：B不早于A结束后的依存系数。
    /// </summary>
    public enum DependencyType
    {
        /// <summary>
        /// 开始时
        /// </summary>
        [Description("开始时")]
        开始时,
        /// <summary>
        /// 在开始之后
        /// </summary>
        [Description("在开始之后")]
        在开始之后,
        /// <summary>
        /// 结束后
        /// </summary>
        [Description("结束后")]
        结束后,
        /// <summary>
        /// 不跟随
        /// </summary>
        [Description("不跟随")]
        不跟随,
        /// <summary>
        /// 可能并行
        /// </summary>
        [Description("可能并行")]
        可能并行,
        /// <summary>
        /// 不并行
        /// </summary>
        [Description("不并行")]
        不并行,
        /// <summary>
        /// 开始后不晚于
        /// </summary>
        [Description("开始后不晚于")]
        开始后不晚于,
        /// <summary>
        /// 开始后不早于
        /// </summary>
        [Description("开始后不早于")]
        开始后不早于,
        /// <summary>
        /// 不晚于结束后
        /// </summary>
        [Description("不晚于结束后")]
        不晚于结束后,
        /// <summary>
        /// 不早于结束后
        /// </summary>
        [Description("不早于结束后")]
        不早于结束后,
        /// <summary>
        /// 其他
        /// </summary>
        [Description("其他")]
        其他
    }
}
