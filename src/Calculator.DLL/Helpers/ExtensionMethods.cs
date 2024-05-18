using System;
using System.ComponentModel;
using System.Reflection;

namespace Calculator.DLL.Helpers
{
    public static class ExtensionMethods
    {
        public static string ToStringEnums<T>(this T en) where T: Enum
        {
            Type type = en.GetType();

            MemberInfo[] memInfo = type.GetMember(en.ToString());
            if (memInfo != null && memInfo.Length > 0)
            {
                object[] attrs = memInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);
                if (attrs != null && attrs.Length > 0)
                    return ((DescriptionAttribute)attrs[0]).Description;
            }
            return en.ToString();
        }
    }
}
