namespace OpenWeatherMapWrapper.Providers
{
    /// <summary>
    /// Interacts with the OneCallAPI for OpenWeatherMap
    /// https://openweathermap.org/api/one-call-api
    /// </summary>
    public class OneCallApiProvider : Provider<DTO.OneCallApi>
    {
        public OneCallApiProvider(Client pClient)
            : base(pClient) { }

        protected override string GetProviderUrl()
        {
            return $"{_Client.GetBaseUrl()}/data/2.5/onecall";
        }
    }
}