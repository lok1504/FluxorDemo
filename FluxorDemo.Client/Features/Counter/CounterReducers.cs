using Fluxor;

namespace FluxorDemo.Client.Features.Counter;

public static class CounterReducers
{
    [ReducerMethod(typeof(CounterIncrementAction))]
    public static CounterState OnIncrement(CounterState state)
    {
        return state with
        {
            CurrentCount = state.CurrentCount + 1
        };
    }

    [ReducerMethod(typeof(CounterDecrementAction))]
    public static CounterState OnDecrement(CounterState state)
    {
        if (state.CurrentCount == 0)
        {
            return state;
        }

        return state with
        {
            CurrentCount = state.CurrentCount - 1
        };
    }

    [ReducerMethod(typeof(CounterResetAction))]
    public static CounterState OnReset(CounterState state)
    {
        return state with
        {
            CurrentCount = 0
        };
    }
}