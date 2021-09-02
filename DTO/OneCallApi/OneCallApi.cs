using Newtonsoft.Json;

namespace OpenWeatherMapWrapper.DTO.OneCallApi
{
    /// <summary>
    /// OneCallAPI response DTO object
    /// </summary>
    public class OneCallApi
    {
        /// <summary>
        /// Latitude of the weather report location
        /// </summary>
        [JsonProperty("lat")]
        public double Latitude { get; set; }

        /// <summary>
        /// Longitude of the weather report location
        /// </summary>
        [JsonProperty("lon")]
        public double Longitude { get; set; }

        /// <summary>
        /// Timezone name of the weather report location
        /// </summary>
        [JsonProperty("timezone")]
        public string TimezoneName { get; set; }

        /// <summary>
        /// Timezone offset of the weather report location
        /// </summary>
        [JsonProperty("timezone_offset")]
        public double TimezoneOffset { get; set; }

        /// <summary>
        /// Current weather data API response
        /// </summary>
        [JsonProperty("current")]
        public Current Current { get; set; }

        /// <summary>
        /// Minute forecast weather data API response
        /// </summary>
        [JsonProperty("minutely")]
        public Minutely[] Minutely { get; set; }

        /// <summary>
        /// Hourly forecast weather data API response
        /// </summary>
        [JsonProperty("hourly")]
        public Hourly[] Hourly { get; set; }

        /// <summary>
        /// Daily forecast weather data API response
        /// </summary>
        [JsonProperty("daily")]
        public Daily[] Daily { get; set; }

        /// <summary>
        /// National weather alerts data from major national weather warning systems
        /// </summary>
        [JsonProperty("alerts")]
        public Alert[] Alerts { get; set; }

        protected OneCallApi()
        {
        }
    }
}