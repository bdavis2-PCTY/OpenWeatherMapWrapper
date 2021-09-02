using Newtonsoft.Json;
using OpenWeatherMapWrapper.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherMapWrapper.DTO.Current
{
    public class Sys
    {
        /// <summary>
        /// (Internal API use)
        /// </summary>
        [JsonProperty("type")]
        public int SysType { get; set; }

        /// <summary>
        /// (Internal API use)
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// (Internal API use)
        /// </summary>
        [JsonProperty("message")]
        public double Message { get; set; }

        /// <summary>
        /// Code of the country
        /// </summary>
        [JsonProperty("country")]
        public string CountryCode { get; set; }

        /// <summary>
        /// Time of sunrise in Unix UTC
        /// </summary>
        [JsonProperty("sunrise")]
        public long SunriseUnixUtc { get; set; }

        /// <summary>
        /// Time of sunset in Unix UTC
        /// </summary>
        [JsonProperty("sunset")]
        public long SunsetUnixUtc { get; set; }

        #region Extra Properties

        /// <summary>
        /// Sunrise in UTC
        /// </summary>
        [JsonIgnore]
        public DateTime SunriseUtc
        {
            get => DateTimeHelpers.UnixTimeStampToDateTime(SunriseUnixUtc);
        }

        /// <summary>
        /// Sunset in UTC
        /// </summary>
        [JsonIgnore]
        public DateTime SunsetUtc
        {
            get => DateTimeHelpers.UnixTimeStampToDateTime(SunsetUnixUtc);
        }

        #endregion

        protected Sys() { }
    }
}
