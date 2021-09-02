using System;
using System.Reflection;

namespace OpenWeatherMapWrapper.Attributes
{
    /// <summary>
    /// Allows for setting the QueryValue of an enum.
    /// This value will then be used to build the request URL.
    /// </summary>
    internal class QueryValueAttribute : Attribute
    {
        public string QueryValue { get; private set; }

        public QueryValueAttribute(string pQueryValue)
        {
            QueryValue = pQueryValue;
        }
    }
}