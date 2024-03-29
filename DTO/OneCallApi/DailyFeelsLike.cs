﻿using Newtonsoft.Json;

namespace OpenWeatherMapWrapper.DTO.OneCallApi
{
    /// <summary>
    /// Represents the human temperature feeling for different parts of the day
    /// </summary>
    public class DailyFeelsLike
    {
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

        protected DailyFeelsLike()
        {
        }
    }
}