using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherMapWrapper.DTO.Current
{
    public class Main
    {
        /// <summary>
        /// Temperature
        /// </summary>
        [JsonProperty("temp")]
        public double Temperature { get; set; }

        /// <summary>
        /// Human perception of weather temperature
        /// </summary>
        [JsonProperty("feels_like")]
        public double FeelsLike { get; set; }

        /// <summary>
        /// Atmospheric pressure on the sea level, hPa
        /// </summary>
        [JsonProperty("pressure")]
        public double Pressure { get; set; }

        /// <summary>
        /// Humidity percentage
        /// </summary>
        [JsonProperty("humidity")]
        public double HumidityPercentage { get; set; }

        /// <summary>
        /// Minimum temperature at the moment
        /// </summary>
        [JsonProperty("temp_min")]
        public double TemperatureMin { get; set; }

        /// <summary>
        /// Maximum temperature at the moment
        /// </summary>
        [JsonProperty("temp_max")]
        public double TemperatureMax { get; set; }

        /// <summary>
        /// Atmospheric pressure on the sea level, hPa
        /// </summary>
        [JsonProperty("sea_level")]
        public double SeaLevel { get; set; }

        /// <summary>
        /// Atmospheric pressure level at ground level, hPa
        /// </summary>
        [JsonProperty("grnd_level")]
        public double GroundLevel { get; set; }

        protected Main() { }

    }
}
