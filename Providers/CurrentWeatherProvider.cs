using System.Text;
using System.Threading.Tasks;

namespace OpenWeatherMapWrapper.Providers
{
    /// <summary>
    /// Interacts with the OneCallAPI for OpenWeatherMap
    /// https://openweathermap.org/api/one-call-api
    /// </summary>
    public class CurrentWeatherProvider : Provider<DTO.Current.Current>
    {
        public CurrentWeatherProvider(Client pClient)
            : base(pClient) { }

        protected override string GetProviderUrl()
        {
            return $"{_Client.GetBaseUrl()}/data/2.5/weather";
        }

        /// <summary>
        /// Gets the current weather by a location's city, state, and country code
        /// </summary>
        /// <param name="pCity"></param>
        /// <param name="pState">Allows NULL</param>
        /// <param name="pCountryCode">Allows NULL</param>
        /// <returns></returns>
        public async Task<DTO.Current.Current> GetByLocation(string pCity, string pState = null, string pCountryCode = null)
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

            string URL = $"{GetBaseUrl()}&q={Location}";
            return (await GetResult(URL));
        }

        /// <summary>
        /// Gets the current weather by a location's city id
        /// </summary>
        /// <param name="pCityId"></param>
        /// <returns></returns>
        public async Task<DTO.Current.Current> GetByCityId(int pCityId)
        {
            string URL = $"{GetBaseUrl()}&id={pCityId}";
            return (await GetResult(URL));
        }

        /// <summary>
        /// Gets the current weather by a location's ZIP code and country code
        /// </summary>
        /// <param name="pCityId"></param>
        /// <returns></returns>
        public async Task<DTO.Current.Current> GetByZipCodeCountryCode(string pZipCode, string pCountryCode)
        {
            string URL = $"{GetBaseUrl()}&zip={pZipCode},{pCountryCode}";
            return (await GetResult(URL));
        }

        /// <summary>
        /// Gets the current weather by a location's latitude and longitude
        /// </summary>
        /// <param name="pLatitude"></param>
        /// <param name="pLongitude"></param>
        /// <returns></returns>
        public async Task<DTO.Current.Current> GetByLatLong(double pLatitude, double pLongitude)
        {
            string URL = $"{GetBaseUrl()}&lat={pLatitude}&lon={pLongitude}";
            return (await GetResult(URL));
        }
    }
}