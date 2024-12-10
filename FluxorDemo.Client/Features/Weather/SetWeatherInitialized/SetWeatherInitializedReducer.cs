using Fluxor;

namespace FluxorDemo.Client.Features.Weather;

public class SetWeatherInitializedReducer
{
    [ReducerMethod(typeof(SetWeatherInitializedAction))]
    public static WeatherState OnSetInitialized(WeatherState state)
    {
        return state with
        {
            Initialized = true
        };
    }
}
