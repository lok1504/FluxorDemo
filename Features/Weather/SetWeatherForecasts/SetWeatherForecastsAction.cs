using FluxorDemo.Models;

namespace FluxorDemo.Features.Weather;

public record SetWeatherForecastsAction(WeatherForecast[] Forecasts);
