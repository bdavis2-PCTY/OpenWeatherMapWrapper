using Newtonsoft.Json;
using System;

namespace OpenWeatherMapWrapper.DTO.OneCallApi
{
    /// <summary>
    /// Represents a Minutely object response
    /// </summary>
    public class Minutely
    {
        /// <summary>
        /// Time of the forecasted data, Unix UTC
        /// <see cref="DateTime"/>
        /// </summary>
        [JsonProperty("dt")]
        public long DateTimeUnixUtc { get; set; }

        /// <summary>
        /// Precipitation volume, mm
        /// </summary>
        [JsonProperty("precipitation")]
        public long Precipitation { get; set; }

        #region Extra Properties

        /// <summary>
        /// DateTimeUnixUtc property converted to DateTime
        /// <see cref="DateTimeUnixUtc"/>
        /// </summary>
        [JsonIgnore]
        public DateTime DateTime
        {
            get => new DateTime(DateTimeUnixUtc);
        }

        #endregion Extra Properties

        protected Minutely()
        {
        }
    }
}