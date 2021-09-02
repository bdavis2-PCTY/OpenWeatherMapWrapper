using Newtonsoft.Json;
using OpenWeatherMapWrapper.Enums;

namespace OpenWeatherMapWrapper.DTO.Current
{
    public class Clouds
    {
        /// <summary>
        /// Cloudiness percentage
        /// </summary>
        [JsonProperty("all")]
        public double CloudPercentage { get; set; }

        protected Clouds() { }
    }
}