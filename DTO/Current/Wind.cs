using Newtonsoft.Json;
using OpenWeatherMapWrapper.Enums;

namespace OpenWeatherMapWrapper.DTO.Current
{
    public class Wind
    {
        /// <summary>
        /// Wind speed
        /// </summary>
        [JsonProperty("speed")]
        public double Speed { get; set; }

        /// <summary>
        /// Wind direction, degrees (meteorological)
        /// </summary>
        [JsonProperty("deg")]
        public double DirectionDegree { get; set; }

        /// <summary>
        /// Wind gust speed
        /// </summary>
        [JsonProperty("gust")]
        public double GustSpeed { get; set; }

        #region Extra Properties

        /// <summary>
        /// Cardinal direction of the wind
        /// </summary>
        [JsonIgnore]
        public CardinalDirectionEnum Direction
        {
            get => Helpers.DirectionHelper.GetCardinalDirectionFromDegree(DirectionDegree);
        }

        #endregion Extra Properties

        protected Wind() { }
    }
}