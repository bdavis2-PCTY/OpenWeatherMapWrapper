using Newtonsoft.Json;
using OpenWeatherMapWrapper.Enums;
using System.Linq;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherMapWrapper.Providers
{
    /// <summary>
    /// Base implementation for providers
    /// </summary>
    /// <typeparam name="T">The type the provider is intending to receive from the API</typeparam>
    public abstract class Provider<T>
    {
        protected readonly Client _Client;

        public Provider(Client pClient)
        {
            _Client = pClient;
        }

        #region Data Fetching

        /// <summary>
        /// Submits an HTTP request the provided URL.
        /// Deserializes and returns the response as <T>.
        /// </summary>
        /// <param name="pURL"></param>
        /// <returns></returns>
        private async Task<T> GetResult(string pURL)
        {
            using (HttpClient HttpClient = new HttpClient())
            {
                HttpResponseMessage Response = await HttpClient.GetAsync(pURL);
                string Json = await Response.Content.ReadAsStringAsync();
                T Deserialized = JsonConvert.DeserializeObject<T>(Json);
                return Deserialized;
            }
        }

        #region Latitude/Longitude

        /// <summary>
        /// Gets the provider data by latitude and longitude
        /// </summary>
        /// <param name="pLatitude"></param>
        /// <param name="pLongitude"></param>
        /// <param name="pExclusions"></param>
        /// <returns></returns>
        public async Task<T> GetByLatLong(double pLatitude, double pLongitude, ExclusionEnum[] pExclusions)
        {
            string URL = GetLatLongUrl(pLatitude, pLongitude, pExclusions);
            return (await GetResult(URL));
        }

        /// <summary>
        /// Gets the provider data by latitude and longitude
        /// </summary>
        /// <param name="pLatitude"></param>
        /// <param name="pLongitude"></param>
        /// <returns></returns>
        public async Task<T> GetByLatLong(double pLatitude, double pLongitude)
        {
            return (await GetByLatLong(pLatitude, pLongitude, new ExclusionEnum[0]));
        }

        /// <summary>
        /// Builds the URL to get data by latitude and longitude
        /// </summary>
        /// <param name="pLatitude"></param>
        /// <param name="pLongitude"></param>
        /// <param name="pExclusions"></param>
        /// <returns></returns>
        private string GetLatLongUrl(double pLatitude, double pLongitude, ExclusionEnum[] pExclusions)
        {
            string URL = $"{GetBaseUrl()}&lat={pLatitude}&lon={pLongitude}";

            // Inject exclusions to the URL
            if (pExclusions.Length > 0)
            {
                URL += "&" + string.Join(",", pExclusions.Select(x => x.GetQueryParam()).ToList());
            }

            return URL;
        }

        #endregion Latitude/Longitude

        #region City/State/Country

        /// <summary>
        /// Gets the data from the current provider by location data
        /// </summary>
        /// <param name="pCity"></param>
        /// <param name="pState"></param>
        /// <param name="pCountryCode"></param>
        /// <returns></returns>
        public async Task<T> GetByLocation(string pCity, string pState, string pCountryCode)
        {
            string URL = GetLocationUrl(pCity, pState, pCountryCode);
            return (await GetResult(URL));
        }

        /// <summary>
        /// Gets the endpoint URL to query by location
        /// </summary>
        /// <param name="pCity"></param>
        /// <param name="pState"></param>
        /// <param name="pCountryCode"></param>
        /// <returns></returns>
        private string GetLocationUrl(string pCity, string pState, string pCountryCode)
        {
            StringBuilder Location = new StringBuilder();
            Location.Append(pCity);

            if (!string.IsNullOrWhiteSpace(pState))
            {
                Location.Append($",{pState}");
            }

            if (!string.IsNullOrWhiteSpace(pCountryCode))
            {
                Location.Append($",{pCountryCode}");
            }

            // Exclusions are not supported
            return $"{GetBaseUrl()}&q={Location}";
        }

        /// <summary>
        /// Gets the endpoint URL to query by a city ID
        /// </summary>
        /// <param name="pCityId"></param>
        /// <returns></returns>
        private string GetLocationUrl(int pCityId)
        {
            return $"{GetBaseUrl()}&id={pCityId}";
        }

        private string GetLocationUrl(string pZipCode, string pCountryCode)
        {
            return $"{GetBaseUrl()}&zip={pZipCode},{pCountryCode}";
        }

        #endregion City/State/Country

        #endregion Data Fetching

        #region URL Building

        /// <summary>
        /// Builds the URL with the app id and unit of measurement
        /// </summary>
        /// <returns></returns>
        private string GetBaseUrl()
        {
            string Url = $"{GetProviderUrl()}?&appid=" + _Client.GetApiKey();

            // Inject Units
            // Default: Standard
            if (_Client.MeasurementUnit != MeasurementUnitEnum.Standard)
            {
                Url += "&units=" + _Client.MeasurementUnit.GetQueryParam();
            }

            return Url;
        }

        /// <summary>
        /// Gets the provider-specific URL
        /// </summary>
        /// <returns></returns>
        protected abstract string GetProviderUrl();

        #endregion URL Building
    }
}