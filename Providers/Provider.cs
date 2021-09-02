using Newtonsoft.Json;
using OpenWeatherMapWrapper.Enums;
using OpenWeatherMapWrapper.Extensions;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace OpenWeatherMapWrapper.Providers
{
    /// <summary>
    /// Base implementation for providers
    /// </summary>
    public abstract class Provider<T>
    {
        protected readonly Client _Client;

        public Provider(Client pClient)
        {
            _Client = pClient;
        }

        /// <summary>
        /// Submits an HTTP request the provided URL.
        /// Deserializes and returns the response as <T>.
        /// </summary>
        /// <param name="pURL"></param>
        /// <returns></returns>
        protected async Task<T> GetResult(string pURL)
        {
            try
            {
                using (HttpClient HttpClient = new HttpClient())
                {
                    HttpResponseMessage Response = await HttpClient.GetAsync(pURL);
                    string Json = await Response.Content.ReadAsStringAsync();
                    T Deserialized = JsonConvert.DeserializeObject<T>(Json);
                    return Deserialized;
                }
            }
            catch (Exception ex)
            {
                System.Console.WriteLine("ERROR! " + ex.Message);
                throw;
            }
        }

        /// <summary>
        /// Builds the URL with the app id and unit of measurement
        /// </summary>
        /// <returns></returns>
        protected string GetBaseUrl()
        {
            string Url = $"{GetProviderUrl()}?&appid=" + _Client.GetApiKey();

            // Inject Units
            // Default: Standard
            if (_Client.MeasurementUnit != MeasurementUnitEnum.Standard)
            {
                Url += "&units=" + _Client.MeasurementUnit.GetQueryValue();
            }

            // Inject Language
            // Default: English
            if (_Client.Language != LanguageEnum.English)
            {
                Url += "&lang=" + _Client.Language.GetQueryValue();
            }

            return Url;
        }

        /// <summary>
        /// Gets the provider-specific URL
        /// </summary>
        /// <returns></returns>
        protected abstract string GetProviderUrl();
    }
}