using System.ComponentModel;

namespace MES.Common
{
    /// <summary>
    /// 定义流程段、操作定义或操作段定义的类型。
    /// 定义的类型有:
    ///     模式:用作其他片段或定义模板的片段或定义;
    ///     实例:可以直接调度和跟踪的段或定义。
    /// </summary>
    public enum DefinitionTypeType
    {
        /// <summary>
        /// 模式
        /// </summary>
        [Description("模式")]
        模式,
        /// <summary>
        /// 实例
        /// </summary>
        [Description("实例")]
        实例
    }
}
