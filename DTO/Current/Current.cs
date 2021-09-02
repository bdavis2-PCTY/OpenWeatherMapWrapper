using Newtonsoft.Json;
using OpenWeatherMapWrapper.Helpers;
using System;

namespace OpenWeatherMapWrapper.DTO.Current
{
    /// <summary>
    /// Represents a current weather response from the API
    /// </summary>
    public class Current
    {
        /// <summary>
        /// Geographical coordinates of the location
        /// </summary>
        [JsonProperty("coord")]
        public Coordinate Coordinate { get; set; }

        /// <summary>
        /// Current weather conditions of the location
        /// </summary>
        [JsonProperty("weather")]
        public Weather Weather { get; set; }

        /// <summary>
        /// (Internal API use)
        /// </summary>
        [JsonProperty("base")]
        public string Base { get; set; }

        /// <summary>
        /// Main weather information
        /// </summary>
        [JsonProperty("main")]
        public Main Main { get; set; }

        /// <summary>
        /// Wind information
        /// </summary>
        [JsonProperty("wind")]
        public Wind Wind { get; set; }

        /// <summary>
        /// Cloud information
        /// </summary>
        [JsonProperty("clouds")]
        public Clouds Clouds { get; set; }

        /// <summary>
        /// Rain information
        /// </summary>
        [JsonProperty("rain")]
        public Rain Rain { get; set; }

        /// <summary>
        /// Snow information
        /// </summary>
        [JsonProperty("snow")]
        public Snow Snow { get; set; }

        /// <summary>
        /// Time of last data pull in Unix UTC
        /// </summary>
        [JsonProperty("dt")]
        public long DateTimeUnixUtc { get; set; }

        /// <summary>
        /// Timezone offset in seconds from UTC
        /// </summary>
        [JsonProperty("timezone")]
        public long Timezone { get; set; }

        /// <summary>
        /// City ID of the location
        /// </summary>
        [JsonProperty("id")]
        public int CityId { get; set; }

        /// <summary>
        /// City name of the location
        /// </summary>
        [JsonProperty("name")]
        public string CityName { get; set; }

        /// <summary>
        /// (Internal Parameter)
        /// </summary>
        [JsonProperty("cod")]
        public object Cod { get; set; }

        #region Extra Properties

        /// <summary>
        /// The Date and Time the last data was pulled in UTC
        /// <see cref="DateTimeUnixUtc"/>
        /// </summary>
        [JsonIgnore]
        public DateTime DateTimeUtc
        {
            get => DateTimeHelpers.UnixTimeStampToDateTime(DateTimeUnixUtc);
        }

        #endregion Extra Properties
    }
}