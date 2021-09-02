# OpenWeatherMapWrapper
An open source .NET wrapper for interacting with the OpenWeatherMap API!
https://openweathermap.org/api

## Using the API
Using the OpenWeatherMapWrapper library is quick and easy!

### 1. Install from NuGet
The first thing you will need to do is install the package from NuGet.
```
PM> Install-Package OpenWeatherMapWrapper
```

### 2. Get an API key from OpenWeatherMap
You will need to register an account with OpenWeather in order to generate an API key.
See https://openweathermap.org/appid .

### 3. Create an instance of Client
In order to utilize OpenWeatherMapWrapper, you will need to create an instance of the Client object. This will allow you to interact directly with OpenWeatherMap.

```cs
var client = new Client("API-KEY");
```

The Client object has several properties that allow you to interact with different APIs of OpenWeather.
```cs
client.OneCallApi // Interact with OneCallAPI: https://openweathermap.org/api/one-call-api
client.Current    // Interact with Current Weather Data API: https://openweathermap.org/current
```

## Examples
See a few exmpales listed below.

#### Pulling OneCallAPI data for a specific geo-coordinate
```cs
double boiseLatitude = 43.615;
double boiseLongitude = -116.2023;

var client = new Client("API-KEY");
var boiseWeather = await client.OneCallApi.GetByLatLong(boiseLatitude, boiseLongitude);
```

#### Pulling current weather for Los Angeles, CA
```cs
var client = new Client("API-KEY");
var laCurrentWeather = await client.Current.GetByLocation("Los Angeles", "CA", "US");
```
