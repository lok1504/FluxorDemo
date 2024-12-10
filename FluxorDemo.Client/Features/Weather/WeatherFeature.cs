using Fluxor;

namespace FluxorDemo.Client.Features.Weather;

public class WeatherFeature : Feature<WeatherState>
{
    public override string GetName() => "Weather";

    protected override WeatherState GetInitialState()
    {
        return new WeatherState
        {
            Initialized = false,
            Loading = false,
            Forecasts = []
        };
    }
}
