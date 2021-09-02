using Newtonsoft.Json;
using OpenWeatherMapWrapper.Helpers;
using System;

namespace OpenWeatherMapWrapper.DTO
{
    /// <summary>
    /// Represents a Current object response
    /// </summary>
    public class Current
    {
        #region JSON properties

        /// <summary>
        /// Current time, Unix, UTC
        /// <see cref="DateTime"/>
        /// </summary>
        [JsonProperty("dt")]
        public long DateTimeUnixUTC { get; set; }

        /// <summary>
        /// Sunrise time, Unix, UTC
        /// <see cref="SunriseDateTime"/>
        /// </summary>
        [JsonProperty("sunrise")]
        public long SunriseUnixUTC { get; set; }

        /// <summary>
        /// Sunset time, Unix, UTC
        /// <see cref="SunsetDateTime"/>
        /// </summary>
        [JsonProperty("sunset")]
        public long SunsetUnixUTC { get; set; }

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
        /// Atmospheric temperature below which water droplets begin to condense and dew can form
        /// </summary>
        [JsonProperty("dew_point")]
        public double DewPoint { get; set; }

        /// <summary>
        /// Cloudiness percentage
        /// </summary>
        [JsonProperty("clouds")]
        public double CloudPercentage { get; set; }

        /// <summary>
        /// Current UV Index
        /// </summary>
        [JsonProperty("uvi")]
        public double UVIndex { get; set; }

        /// <summary>
        /// Average visibility
        /// </summary>
        [JsonProperty("visibility")]
        public double Visibility { get; set; }

        /// <summary>
        /// Wind speed
        /// </summary>
        [JsonProperty("wind_speed")]
        public double WindSpeed { get; set; }

        /// <summary>
        /// Wind gust speed
        /// </summary>
        [JsonProperty("wind_gust")]
        public double? WindGust { get; set; }

        /// <summary>
        /// Wind direction in degrees
        /// </summary>
        [JsonProperty("wind_deg")]
        public int WindDirectionDegree { get; set; }

        /// <summary>
        /// Precipitation volume, MM
        /// </summary>
        [JsonProperty("rain")]
        public double? Rain { get; set; }

        /// <summary>
        /// Snow volume, MM
        /// </summary>
        [JsonProperty("snow")]
        public double? Snow { get; set; }

        /// <summary>
        /// The current weather
        /// </summary>
        [JsonProperty("weather")]
        public Weather[] Weather { get; set; }

        #endregion JSON properties

        #region Extra properties

        /// <summary>
        /// DateTimeUnixUTC converted to a DateTime object
        /// <see cref="DateTimeUnixUTC"/>
        /// </summary>
        [JsonIgnore]
        public DateTime DateTime { get => DateTimeHelpers.UnixTimeStampToDateTime(DateTimeUnixUTC); }

        /// <summary>
        /// SunriseUnixUTC converted to a DateTime object
        /// <see cref="SunriseUnixUTC"/>
        /// </summary>
        [JsonIgnore]
        public DateTime SunriseDateTime { get => DateTimeHelpers.UnixTimeStampToDateTime(SunriseUnixUTC); }

        /// <summary>
        /// SunsetUnixUTC converted to a DateTime object
        /// <see cref="SunsetUnixUTC"/>
        /// </summary>
        [JsonIgnore]
        public DateTime SunsetDateTime { get => DateTimeHelpers.UnixTimeStampToDateTime(SunsetUnixUTC); }

        /// <summary>
        /// Wind direction as a cardinal direction
        /// </summary>
        [JsonIgnore]
        public Enums.CardinalDirectionEnum WindDirection { get => Helpers.DirectionHelper.GetCardinalDirectionFromDegree(WindDirectionDegree); }

        #endregion Extra properties

        protected Current()
        {
        }
    }
}