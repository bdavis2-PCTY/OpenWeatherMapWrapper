using System;

namespace OpenWeatherMapWrapper.Enums
{
    /// <summary>
    /// Measurement options available
    /// https://openweathermap.org/api/one-call-api#data
    /// </summary>
    public enum MeasurementUnitEnum
    {
        Standard = 0,
        Metric = 1,
        Imperial = 2
    }

    /// <summary>
    /// Adds a .GetQueryParam() to the exclusion enum values
    /// This is used to build the URLs
    /// </summary>
    public static class MeasurementUnitEnumExtensions
    {
        public static string GetQueryParam(this MeasurementUnitEnum pValue)
        {
            switch (pValue)
            {
                case MeasurementUnitEnum.Standard:
                    return "standard";

                case MeasurementUnitEnum.Metric:
                    return "metric";

                case MeasurementUnitEnum.Imperial:
                    return "imperial";

                default:
                    throw new NotImplementedException();
            }
        }
    }
}