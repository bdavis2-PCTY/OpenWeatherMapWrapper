using Newtonsoft.Json;

namespace OpenWeatherMapWrapper.DTO
{
    /// <summary>
    /// Represents an OpenWeather Coordinate
    /// </summary>
    public class Coordinate
    {
        [JsonProperty("lat")]
        public double Latitude { get; set; }

        [JsonProperty("lon")]
        public double Longitude { get; set; }

        protected Coordinate()
        {
        }
    }
}