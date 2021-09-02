using OpenWeatherMapWrapper.Attributes;

namespace OpenWeatherMapWrapper.Enums
{
    /// <summary>
    /// Items that can be excluded from a request
    /// </summary>
    public enum ExclusionEnum
    {
        [QueryValue("current")]
        Current,

        [QueryValue("minutely")]
        Minutely,

        [QueryValue("hourly")]
        Hourly,

        [QueryValue("daily")]
        Daily,

        [QueryValue("alerts")]
        Alerts
    }
}