using Fluxor.Blazor.Web.Components;
using Fluxor;
using FluxorDemo.Features.Weather;
using FluxorDemo.Models;
using Microsoft.AspNetCore.Components;

namespace FluxorDemo.Pages;

public partial class Weather : FluxorComponent
{
    [Inject]
    protected IDispatcher Dispatcher { get; set; }

    [Inject]
    protected IState<WeatherState> WeatherState { get; set; }

    private WeatherForecast[] Forecasts => WeatherState.Value.Forecasts;
    private bool Loading => WeatherState.Value.Loading;

    protected override void OnInitialized()
    {
        if (WeatherState.Value.Initialized == false)
        {
            LoadForecasts();
            Dispatcher.Dispatch(new SetWeatherInitializedAction());
        }

        base.OnInitialized();
    }

    private void LoadForecasts()
    {
        Dispatcher.Dispatch(new LoadWeatherForecastsAction());
    }
}
