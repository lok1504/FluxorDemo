using Fluxor;

namespace FluxorDemo.Client.Features.Weather;

public class SetWeatherForecastsReducer
{
    [ReducerMethod]
    public static WeatherState OnSetForecasts(
        WeatherState state, SetWeatherForecastsAction action)
    {
        return state with
        {
            Forecasts = action.Forecasts,
            Loading = false
        };
    }
}
