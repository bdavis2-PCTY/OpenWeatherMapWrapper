using OpenWeatherMapWrapper.Attributes;
using System;
using System.Reflection;

namespace OpenWeatherMapWrapper.Extensions
{
    /// <summary>
    /// Common extensions for enums
    /// </summary>
    internal static class EnumExtensions
    {
        /// <summary>
        /// Gets the QueryValue attribute of an enum value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string GetQueryValue(this Enum value)
        {
            var type = value.GetType();
            return type.GetField(Enum.GetName(type, value)).GetCustomAttribute<QueryValueAttribute>()?.QueryValue ?? null;
        }
    }
}