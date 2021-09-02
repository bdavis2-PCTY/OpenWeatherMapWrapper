using System;

namespace OpenWeatherMapWrapper.Enums
{
    /// <summary>
    /// Items that can be excluded from a request
    /// </summary>
    public enum ExclusionEnum
    {
        Current,
        Minutely,
        Hourly,
        Daily,
        Alerts
    }

    /// <summary>
    /// Adds a .GetQueryParam() to the exclusion enum values
    /// This is used to build the URLs
    /// </summary>
    public static class ExlusionEnumExtensions
    {
        public static string GetQueryParam(this ExclusionEnum pValue)
        {
            switch (pValue)
            {
                case ExclusionEnum.Current:
                    return "current";

                case ExclusionEnum.Minutely:
                    return "minutely";

                case ExclusionEnum.Hourly:
                    return "hourly";

                case ExclusionEnum.Daily:
                    return "daily";

                case ExclusionEnum.Alerts:
                    return "alerts";

                default:
                    throw new NotImplementedException();
            }
        }
    }
}