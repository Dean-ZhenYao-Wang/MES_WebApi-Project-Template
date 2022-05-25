using System.ComponentModel;

namespace MES.Common
{
    /// <summary>
    /// 定义属性的类型。
    /// 定义类型
    ///     类类型:属性值是为类定义的，没有值与实例相关联;
    ///     实例类型:类的属性值未定义;属性值被定义为类的默认实例值，但是类的个别实例可能会重新定义特定的值。
    ///     默认类型:属性值被定义为类的默认实例值，但是类的个别实例可能会重新定义特定的值。
    /// </summary>
    public enum ClassPropertyTypeType
    {
        /// <summary>
        /// 类类型
        /// </summary>
        [Description("类类型")]
        类类型,
        /// <summary>
        /// 实例类型
        /// </summary>
        [Description("实例类型")]
        实例类型,
        /// <summary>
        /// 默认类型
        /// </summary>
        [Description("默认类型")]
        默认类型,
        /// <summary>
        /// 其他
        /// </summary>
        [Description("其他")]
        其他
    }
}
