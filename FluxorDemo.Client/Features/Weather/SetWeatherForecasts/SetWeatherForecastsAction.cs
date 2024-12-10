using FluxorDemo.Shared;

namespace FluxorDemo.Client.Features.Weather;

public record SetWeatherForecastsAction(WeatherForecast[] Forecasts);
