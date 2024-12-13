using Fluxor;
using Fluxor.Blazor.Web.Components;
using FluxorDemo.Client.Features.NotificationHub;
using FluxorDemo.Shared;
using Microsoft.AspNetCore.Components;

namespace FluxorDemo.Client.Pages;

public partial class Home : FluxorComponent
{
    [Inject]
    protected IDispatcher Dispatcher { get; set; }

    [Inject]
    protected IState<NotificationHubState> NotificationHubState { get; set; }

    private List<NotificationMessage> Messages => NotificationHubState.Value.Messages;
    private bool Connected => NotificationHubState.Value.Connected;

    private void SendMessage()
    {
        var message = "Lorem ipsum dolor sit amet.";
        Dispatcher.Dispatch(new SendNotificationHubMessageAction(message));
    }
}
