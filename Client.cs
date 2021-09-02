using OpenWeatherMapWrapper.Enums;
using OpenWeatherMapWrapper.Providers;

namespace OpenWeatherMapWrapper
{
    /// <summary>
    /// Client layer to interact with OpenWeatherMap
    /// </summary>
    public class Client
    {
        private readonly string _apiKey;

        /// <summary>
        /// Creates a new client instance using an API key, measurement unit, and language
        /// </summary>
        /// <param name="pApiKey"></param>
        /// <param name="pMeasurementUnit"></param>
        /// <param name="pLanguage"></param>
        public Client(string pApiKey, MeasurementUnitEnum pMeasurementUnit = MeasurementUnitEnum.Standard, LanguageEnum pLanguage = LanguageEnum.English)
        {
            _apiKey = pApiKey;
            MeasurementUnit = pMeasurementUnit;
            Language = pLanguage;
        }


        /// <summary>
        /// Gets the API key to be used
        /// </summary>
        /// <returns></returns>
        internal string GetApiKey()
        {
            return _apiKey;
        }

        /// <summary>
        /// Gets the base URL for the OpenWeatherMap API
        /// </summary>
        /// <returns></returns>
        internal string GetBaseUrl()
        {
            return "https://api.openweathermap.org";
        }

        #region Optional Settings

        /// <summary>
        /// Measurement unit to use for API responses
        /// </summary>
        public MeasurementUnitEnum MeasurementUnit { get; set; }

        /// <summary>
        /// Language to use for API response
        /// </summary>
        public LanguageEnum Language { get; set; }

        #endregion Optional Settings

        #region Providers

        /// <summary>
        /// Interact with OneCallAPI
        /// https://openweathermap.org/api/one-call-api
        /// </summary>
        public OneCallApiProvider OneCallApi
        {
            get => (_oneCallApiProvider == null ? _oneCallApiProvider = new OneCallApiProvider(this) : _oneCallApiProvider);
        }

        private OneCallApiProvider _oneCallApiProvider = null;

        /// <summary>
        /// Interact with Current Weather API
        /// https://openweathermap.org/current
        /// </summary>
        public CurrentWeatherProvider CurrentWeather
        {
            get => (_currentWeatherProvider == null ? _currentWeatherProvider = new CurrentWeatherProvider(this) : _currentWeatherProvider);
        }

        private CurrentWeatherProvider _currentWeatherProvider = null;

        #endregion Providers
    }
}