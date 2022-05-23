using System;
using System.ComponentModel;
using System.Reflection;

namespace Util
{
    public static partial class Extention
    {
        public static string GetDescription(this Enum value)
        {
            Type enumType = value.GetType();
            string name = Enum.GetName(enumType, value);
            if (name != null)
            {
                FieldInfo fieldInfo = enumType.GetField(name);
                if (fieldInfo != null)
                {
                    if (Attribute.GetCustomAttribute(fieldInfo, typeof(DescriptionAttribute), false) is DescriptionAttribute attr)
                    {
                        return attr.Description;
                    }
                }
            }
            return null;
        }
    }
}