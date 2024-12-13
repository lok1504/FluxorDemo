using Fluxor;

namespace FluxorDemo.Client.Features.NotificationHub;

public static class SetNotificationHubConnectedReducer
{
    [ReducerMethod]
    public static NotificationHubState OnSetConnected(
        NotificationHubState state, SetNotificationHubConnectedAction action)
    {
        return state with
        {
            Connected = action.Connected
        };
    }
}
