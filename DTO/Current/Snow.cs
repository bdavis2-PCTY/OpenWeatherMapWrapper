using Newtonsoft.Json;

namespace OpenWeatherMapWrapper.DTO.Current
{
    public class Snow
    {
        /// <summary>
        /// Rain volume for the last 1 hour, mm
        /// </summary>
        [JsonProperty("1h")]
        public double LastOneHour { get; set; }

        /// <summary>
        /// Rain volume for the last 3 hours, mm
        /// </summary>
        [JsonProperty("3h")]
        public double LastThreeHour { get; set; }

        protected Snow()
        {
        }
    }
}