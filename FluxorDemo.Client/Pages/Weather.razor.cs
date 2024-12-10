using Fluxor;
using Fluxor.Blazor.Web.Components;
using FluxorDemo.Client.Features.Weather;
using FluxorDemo.Shared;
using Microsoft.AspNetCore.Components;

namespace FluxorDemo.Client.Pages;

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
