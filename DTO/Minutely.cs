using Newtonsoft.Json;
using System;

namespace OpenWeatherMapWrapper.DTO
{
    /// <summary>
    /// Represents a Minutely object response
    /// </summary>
    public class Minutely
    {
        /// <summary>
        /// Time of the forecasted data, Unix, UTC
        /// <see cref="DateTime"/>
        /// </summary>
        [JsonProperty("dt")]
        public long DateTimeUnixUTC { get; set; }

        /// <summary>
        /// Precipitation volume, mm
        /// </summary>
        [JsonProperty("precipitation")]
        public long Precipitation { get; set; }

        /// <summary>
        /// DateTimeUnixUTC property converted to DateTime
        /// <see cref="DateTimeUnixUTC"/>
        /// </summary>
        [JsonIgnore]
        public DateTime DateTime
        {
            get => new DateTime(DateTimeUnixUTC);
        }

        protected Minutely()
        {
        }
    }
}