using FluxorDemo.Shared;
using Microsoft.AspNetCore.SignalR;

namespace FluxorDemo.Api.Hubs;

public class NotificationHub : Hub
{
    public async Task SendMessage(NotificationMessage message)
    {
        await Clients.Others.SendAsync("ReceiveMessage", message);
    }
}
