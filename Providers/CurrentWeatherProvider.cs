namespace OpenWeatherMapWrapper.Providers
{
    /// <summary>
    /// Interacts with the OneCallAPI for OpenWeatherMap
    /// https://openweathermap.org/api/one-call-api
    /// </summary>
    public class CurrentWeatherProvider : Provider<DTO.OneCallApi>
    {
        public CurrentWeatherProvider(Client pClient)
            : base(pClient) { }

        protected override string GetProviderUrl()
        {
            return $"{_Client.GetBaseUrl()}/data/2.5/weather";
        }
    }
}