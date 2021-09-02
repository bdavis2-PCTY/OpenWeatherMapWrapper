using OpenWeatherMapWrapper.Attributes;

namespace OpenWeatherMapWrapper.Enums
{
    /// <summary>
    /// Measurement options available
    /// https://openweathermap.org/api/one-call-api#data
    /// </summary>
    public enum MeasurementUnitEnum
    {
        [QueryValue("standard")]
        Standard = 0,

        [QueryValue("metric")]
        Metric = 1,

        [QueryValue("imperial")]
        Imperial = 2
    }
}