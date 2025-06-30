using System.ComponentModel;
using System.Reflection;
using System.Runtime.Serialization;

namespace CG.Helpers
{
    public static class EnumHelper
    {
        public static string GetEnumMemberValue(Enum value)
        {
            var field = value.GetType().GetField(value.ToString());

            if (field == null) return null;

            var attributes = field.GetCustomAttributes(typeof(EnumMemberAttribute), false);

            if (attributes.Length == 0) return null;

            return ((EnumMemberAttribute)attributes[0]).Value;
        }
        public static string GetDescriptionEnum(Enum value)
        {
            var descriptionAttribute = value.GetType()
                .GetMember(value.ToString())[0]
                .GetCustomAttributes(typeof(DescriptionAttribute), inherit: false)[0] as DescriptionAttribute;
            return descriptionAttribute != null ? descriptionAttribute.Description : "";
        }
        public static string GetValueByDescriptionEnum<T>(string value)
        {
            FieldInfo[] fields = typeof(T).GetFields();

            foreach (FieldInfo field in fields)
            {
                if (field.GetCustomAttributes(typeof(DescriptionAttribute), false).Count() > 0)
                {
                    if (((DescriptionAttribute)field.GetCustomAttributes(typeof(DescriptionAttribute), false)[0]).Description == value)
                    {
                        return field.Name;
                    }
                }
            }
            
            return "Россия";
        }
    }
}
