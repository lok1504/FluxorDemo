using FluxorDemo.Models;
using System.Net.Http.Json;

namespace FluxorDemo.Pages;

public partial class Weather
{
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
    }
}
