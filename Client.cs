using OpenWeatherMapWrapper.Enums;
using OpenWeatherMapWrapper.Providers;
using System;

namespace OpenWeatherMapWrapper
{
    /// <summary>
    /// Client layer to interact with OpenWeatherMap
    /// </summary>
    public class Client
    {
        private readonly string _apiKey;

        /// <summary>
        /// Creates a new client instance using an API key.
        /// Uses Standard as the measurement unit.
        /// </summary>
        /// <param name="pApiKey"></param>
        public Client(string pApiKey)
            : this(pApiKey, MeasurementUnitEnum.Standard) { }

        /// <summary>
        /// Creates a new client instance using an API key and a measurement unit.
        /// </summary>
        /// <param name="pApiKey"></param>
        /// <param name="pMeasurementUnit"></param>
        public Client(string pApiKey, MeasurementUnitEnum pMeasurementUnit)
        {
            _apiKey = pApiKey;
            MeasurementUnit = pMeasurementUnit;
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

        #endregion Optional Settings

        #region Providers

        /// <summary>
        /// Interact with OneCallAPI
        /// https://openweathermap.org/api/one-call-api
        /// </summary>
        public OneCallApiProvider OneCallApi
        {
            get
            {
                if (_oneCallApi == null)
                {
                    _oneCallApi = new OneCallApiProvider(this);
                }

                return _oneCallApi;
            }
        }

        private OneCallApiProvider _oneCallApi = null;

        #endregion Providers
    }
}