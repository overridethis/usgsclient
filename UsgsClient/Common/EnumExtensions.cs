using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace UsgsClient.Common
{
    public static class EnumExtensions
    {
        public static T GetAttributeOfType<T>(this Enum value) where T : System.Attribute
        {
            var typeInfo = value.GetType().GetTypeInfo();
            var memInfo = typeInfo.DeclaredMembers
                .First(mbr => mbr.Name == value.ToString());
            var attributes = memInfo.GetCustomAttributes(typeof(T), false)
                .ToList();
            return attributes.Any() ? (T)attributes[0] : null;
        }

        public static string GetDescription(this Enum value)
        {
            return value
                .GetAttributeOfType<DescriptionAttribute>()?
                .Description;
        }
    }
}
