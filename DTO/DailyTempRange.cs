using Newtonsoft.Json;

namespace OpenWeatherMapWrapper.DTO
{
    /// <summary>
    /// Represents the different temperatures of a day
    /// </summary>
    public class DailyTempRange
    {
        /// <summary>
        /// Minimum daily temperature
        /// </summary>
        [JsonProperty("min")]
        public double Minimum { get; set; }

        /// <summary>
        /// Maximum daily temperature
        /// </summary>
        [JsonProperty("max")]
        public double Maximum { get; set; }

        /// <summary>
        /// Morning temperature
        /// </summary>
        [JsonProperty("morn")]
        public double Morning { get; set; }

        /// <summary>
        /// Day temperature
        /// </summary>
        [JsonProperty("day")]
        public double Day { get; set; }

        /// <summary>
        /// Evening temperature
        /// </summary>
        [JsonProperty("eve")]
        public double Evening { get; set; }

        /// <summary>
        /// Night temperature
        /// </summary>
        [JsonProperty("night")]
        public double Night { get; set; }

        protected DailyTempRange()
        {
        }
    }
}