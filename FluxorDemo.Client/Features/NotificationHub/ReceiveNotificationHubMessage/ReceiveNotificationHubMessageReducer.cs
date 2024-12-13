using Fluxor;
using FluxorDemo.Shared;

namespace FluxorDemo.Client.Features.NotificationHub;

public static class ReceiveNotificationHubMessageReducer
{
    [ReducerMethod]
    public static NotificationHubState OnReceiveNotificationHubMessage(
        NotificationHubState state, ReceiveNotificationHubMessageAction action)
    {
        var messages = new List<NotificationMessage>();
        messages.AddRange(state.Messages);
        messages.Add(action.Message);

        return state with
        {
            Messages = messages
        };
    }
}
