using Fluxor;

namespace FluxorDemo.Client.Features.NotificationHub;

public class NotificationHubFeature : Feature<NotificationHubState>
{
    public override string GetName() => "NotificationHub";

    protected override NotificationHubState GetInitialState()
    {
        return new NotificationHubState
        {
            Connected = false,
            Messages = []
        };
    }
}
