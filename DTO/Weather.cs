using Newtonsoft.Json;

namespace OpenWeatherMapWrapper.DTO
{
    public class Weather
    {
        /// <summary>
        /// Informative weather ID
        /// https://openweathermap.org/weather-conditions#Weather-Condition-Codes-2
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// Group of weather condition (Rain, Snow, Clear, Etc.)
        /// </summary>
        [JsonProperty("main")]
        public string Main { get; set; }

        /// <summary>
        /// Brief description of the weather
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Weather icon name
        /// </summary>
        [JsonProperty("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// HTTP URL of the weather icon
        /// https://openweathermap.org/weather-conditions#Icon-list
        /// </summary>
        [JsonIgnore]
        public string IconUrl
        {
            get => $"http://openweathermap.org/img/wn/{Icon}@2x.png";
        }

        protected Weather()
        {
        }
    }
}