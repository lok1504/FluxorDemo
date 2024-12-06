using Fluxor;

namespace FluxorDemo.Features.Weather;

public class LoadWeatherForecastsReducer
{
    [ReducerMethod(typeof(LoadWeatherForecastsAction))]
    public static WeatherState OnLoadWeatherForecasts(WeatherState state)
    {
        return state with
        {
            Loading = true
        };
    }
}
