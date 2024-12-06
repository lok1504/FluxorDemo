using Fluxor;
using Fluxor.Blazor.Web.Components;
using FluxorDemo.Features.Counter;
using Microsoft.AspNetCore.Components;

namespace FluxorDemo.Pages;

public partial class Counter : FluxorComponent
{
    [Inject]
    protected IDispatcher Dispatcher { get; set; }

    [Inject]
    protected IState<CounterState> CounterState { get; set; }

    private void IncrementCount()
    {
        Dispatcher.Dispatch(new CounterIncrementAction());
    }

    private void DecrementCount()
    {
        Dispatcher.Dispatch(new CounterDecrementAction());
    }

    private void ResetCount()
    {
        Dispatcher.Dispatch(new CounterResetAction());
    }
}
