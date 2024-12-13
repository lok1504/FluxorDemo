using Fluxor;
using FluxorDemo.Client.Features.NotificationHub;
using Microsoft.AspNetCore.Components;

namespace FluxorDemo.Client.Layout;

public partial class MainLayout : LayoutComponentBase
{
    [Inject]
    protected IDispatcher Dispatcher { get; set; }

    protected override void OnInitialized()
    {
        base.OnInitialized();
        Dispatcher.Dispatch(new StartNotificationHubAction());
    }
}
