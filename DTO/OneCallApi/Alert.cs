using Newtonsoft.Json;
using OpenWeatherMapWrapper.Helpers;
using System;

namespace OpenWeatherMapWrapper.DTO.OneCallApi
{
    /// <summary>
    /// Represents a national weather alert
    /// </summary>
    public class Alert
    {
        /// <summary>
        /// Name of the alert source
        /// https://openweathermap.org/api/one-call-api#listsource
        /// </summary>
        [JsonProperty("sender_name")]
        public string SenderName { get; set; }

        /// <summary>
        /// Alert event name
        /// </summary>
        [JsonProperty("event")]
        public string EventName { get; set; }

        /// <summary>
        /// Start date and time of the alert in Unix UTC
        /// </summary>
        [JsonProperty("start")]
        public long StartTimeUnixUtc { get; set; }

        /// <summary>
        /// End date and time of the alert in Unix UTC
        /// </summary>
        [JsonProperty("end")]
        public long EndTimeUnixUtc { get; set; }

        /// <summary>
        /// Description of the alert
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Type of severe weather
        /// </summary>
        [JsonProperty("tags")]
        public object Tags { get; set; }

        #region Extra Properties

        /// <summary>
        /// Date and time when the alert ends in UTC
        /// </summary>
        [JsonIgnore]
        public DateTime EndDateTimeUtc
        {
            get => DateTimeHelpers.UnixTimeStampToDateTime(EndTimeUnixUtc);
        }

        #endregion

        protected Alert()
        {
        }
    }
}