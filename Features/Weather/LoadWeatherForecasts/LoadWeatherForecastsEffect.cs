using Fluxor;
using FluxorDemo.Models;
using System.Net.Http.Json;

namespace FluxorDemo.Features.Weather;

public class LoadWeatherForecastsEffect(HttpClient http)
{
    [EffectMethod(typeof(LoadWeatherForecastsAction))]
    public async Task LoadForecasts(IDispatcher dispatcher)
    {
        var forecasts = await http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
        dispatcher.Dispatch(new SetWeatherForecastsAction(forecasts));
    }
}
