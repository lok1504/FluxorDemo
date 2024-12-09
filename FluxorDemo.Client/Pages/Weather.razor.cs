using FluxorDemo.Shared;
using Microsoft.AspNetCore.Components;
using System.Net.Http.Json;

namespace FluxorDemo.Client.Pages;

public partial class Weather
{
    [Inject]
    protected HttpClient Http { get; set; }

    private WeatherForecast[]? forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
    }
}
