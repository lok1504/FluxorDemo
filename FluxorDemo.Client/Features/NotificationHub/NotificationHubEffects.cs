using Fluxor;
using FluxorDemo.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.SignalR.Client;

namespace FluxorDemo.Client.Features.NotificationHub;

public class NotificationHubEffects
{
    private readonly HubConnection _hubConnection;

    public NotificationHubEffects(
        NavigationManager navigationManager, ILogger<NotificationHubEffects> logger)
    {
        _hubConnection = new HubConnectionBuilder()
            .WithUrl(navigationManager.ToAbsoluteUri("/notificationHub"))
            .WithAutomaticReconnect()
            .Build();
    }

    [EffectMethod(typeof(StartNotificationHubAction))]
    public async Task StartNotificationHub(IDispatcher dispatcher)
    {
        await _hubConnection.StartAsync();
        Console.WriteLine($"{_hubConnection.ConnectionId} connected to notification hub");

        _hubConnection.Reconnecting += (ex) =>
        {
            dispatcher.Dispatch(new SetNotificationHubConnectedAction(false));
            return Task.CompletedTask;
        };

        _hubConnection.Reconnected += (connectionId) =>
        {
            dispatcher.Dispatch(new SetNotificationHubConnectedAction(true));
            return Task.CompletedTask;
        };

        _hubConnection.On<NotificationMessage>("ReceiveMessage", 
            (message) => dispatcher.Dispatch(new ReceiveNotificationHubMessageAction(message)));

        dispatcher.Dispatch(new SetNotificationHubConnectedAction(true));
    }

    [EffectMethod]
    public async Task SendNotificationMessage(
        SendNotificationHubMessageAction action, IDispatcher dispatcher)
    {
        var message = new NotificationMessage()
        {
            Title = $"Client #{_hubConnection.ConnectionId} Message",
            Message = action.Message
        };

        await _hubConnection.SendAsync("SendMessage", message);
    }
}
