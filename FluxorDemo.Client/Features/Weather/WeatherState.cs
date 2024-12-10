using FluxorDemo.Shared;

namespace FluxorDemo.Client.Features.Weather;

public record WeatherState
{
    public bool Initialized { get; init; }
    public bool Loading { get; init; }
    public WeatherForecast[] Forecasts { get; init; }
}
