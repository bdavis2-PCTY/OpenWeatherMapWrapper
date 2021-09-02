using OpenWeatherMapWrapper.Enums;
using OpenWeatherMapWrapper.Extensions;
using OpenWeatherMapWrapper.Helpers;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace OpenWeatherMapWrapper.Providers
{
    /// <summary>
    /// Interacts with the OneCallAPI for OpenWeatherMap
    /// https://openweathermap.org/api/one-call-api
    /// </summary>
    public class OneCallApiProvider : Provider<DTO.OneCallApi.OneCallApi>
    {
        /// <summary>
        /// The Unix Utc timestamp to be used to indicate current
        /// </summary>
        private const int CURRENT_TIMESTAMP = -1;

        public OneCallApiProvider(Client pClient)
            : base(pClient) { }

        protected override string GetProviderUrl()
        {
            return $"{_Client.GetBaseUrl()}/data/2.5/onecall";
        }

        /// <summary>
        /// Gets the provider data by latitude and longitude.
        /// Allows for a historical date and specified fields to be excluded.
        /// </summary>
        /// <param name="pLatitude"></param>
        /// <param name="pLongitude"></param>
        /// <param name="pTimestamp">The DateTime in Unix Utc for the date to pull data for</param>
        /// <param name="pExclusions"></param>
        /// <returns></returns>
        public async Task<DTO.OneCallApi.OneCallApi> GetByLatLong(double pLatitude, double pLongitude, long pTimestamp, ExclusionEnum[] pExclusions)
        {
            string URL = $"{GetBaseUrl()}&lat={pLatitude}&lon={pLongitude}";

            // Inject exclusions to the URL
            if (pExclusions.Length > 0)
            {
                URL += "&" + string.Join(",", pExclusions.Select(x => x.GetQueryValue()).ToList());
            }

            // Inject timestamp (if available)
            // https://openweathermap.org/api/one-call-api#history
            if (pTimestamp > CURRENT_TIMESTAMP)
            {
                URL += "&dt=" + pTimestamp;
            }

            return (await GetResult(URL));
        }

        /// <summary>
        /// Gets the provider data by latitude and longitude.
        /// Allows for a historical date and specified fields to be excluded.
        /// </summary>
        /// <param name="pLatitude"></param>
        /// <param name="pLongitude"></param>
        /// <param name="pTimestamp">The DateTime in Utc for the date to pull data for</param>
        /// <param name="pExclusions"></param>
        /// <returns></returns>
        public async Task<DTO.OneCallApi.OneCallApi> GetByLatLong(double pLatitude, double pLongitude, DateTime pTimestamp, ExclusionEnum[] pExclusions)
        {
            return (await GetByLatLong(pLatitude, pLongitude, DateTimeHelpers.DateTimeToUnixTimeStamp(pTimestamp), pExclusions));
        }

        /// <summary>
        /// Gets the provider data by latitude and longitude.
        /// Allows for specified fields to be excluded.
        /// </summary>
        /// <param name="pLatitude"></param>
        /// <param name="pLongitude"></param>
        /// <param name="pExclusions"></param>
        /// <returns></returns>
        public async Task<DTO.OneCallApi.OneCallApi> GetByLatLong(double pLatitude, double pLongitude, ExclusionEnum[] pExclusions)
        {
            return (await GetByLatLong(pLatitude, pLongitude, CURRENT_TIMESTAMP, pExclusions));
        }

        /// <summary>
        /// Gets the provider data by latitude and longitude.
        /// Allows for a historical date.
        /// </summary>
        /// <param name="pLatitude"></param>
        /// <param name="pLongitude"></param>
        /// <param name="pTimestamp">The DateTime in Unix Utc for the date to pull data for</param>
        /// <returns></returns>
        public async Task<DTO.OneCallApi.OneCallApi> GetByLatLong(double pLatitude, double pLongitude, long pTimestamp)
        {
            return (await GetByLatLong(pLatitude, pLongitude, pTimestamp, new ExclusionEnum[0]));
        }

        /// <summary>
        /// Gets the provider data by latitude and longitude.
        /// Allows for a historical date.
        /// </summary>
        /// <param name="pLatitude"></param>
        /// <param name="pLongitude"></param>
        /// <param name="pTimestamp">The DateTime in Utc for the date to pull data for</param>
        /// <returns></returns>
        public async Task<DTO.OneCallApi.OneCallApi> GetByLatLong(double pLatitude, double pLongitude, DateTime pTimestamp)
        {
            return (await GetByLatLong(pLatitude, pLongitude, DateTimeHelpers.DateTimeToUnixTimeStamp(pTimestamp), new ExclusionEnum[0]));
        }

        /// <summary>
        /// Gets the provider data by latitude and longitude.
        /// </summary>
        /// <param name="pLatitude"></param>
        /// <param name="pLongitude"></param>
        /// <returns></returns>
        public async Task<DTO.OneCallApi.OneCallApi> GetByLatLong(double pLatitude, double pLongitude)
        {
            return (await GetByLatLong(pLatitude, pLongitude, CURRENT_TIMESTAMP, new ExclusionEnum[0]));
        }
    }
}