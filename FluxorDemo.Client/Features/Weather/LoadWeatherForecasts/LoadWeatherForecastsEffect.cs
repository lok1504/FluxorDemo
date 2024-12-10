using Fluxor;
using FluxorDemo.Shared;
using System.Net.Http.Json;

namespace FluxorDemo.Client.Features.Weather;

public class LoadWeatherForecastsEffect(HttpClient http)
{
    [EffectMethod(typeof(LoadWeatherForecastsAction))]
    public async Task LoadForecasts(IDispatcher dispatcher)
    {
        var forecasts = await http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
        dispatcher.Dispatch(new SetWeatherForecastsAction(forecasts));
    }
}
