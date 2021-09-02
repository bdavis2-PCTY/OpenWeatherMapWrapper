using Newtonsoft.Json;

namespace OpenWeatherMapWrapper.DTO
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
        /// Start date and time of the alert in Unix, UTC
        /// </summary>
        [JsonProperty("start")]
        public long StartTimeUnixUTC { get; set; }

        /// <summary>
        /// End date and time of the alert in Unix, UTC
        /// </summary>
        [JsonProperty("end")]
        public long EndTimeUnixUTC { get; set; }

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

        protected Alert()
        {
        }
    }
}