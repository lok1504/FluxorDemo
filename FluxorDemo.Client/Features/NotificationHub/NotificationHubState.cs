using FluxorDemo.Shared;

namespace FluxorDemo.Client.Features.NotificationHub;

public record NotificationHubState
{
    public bool Connected { get; init; }
    public List<NotificationMessage> Messages { get; init; }
}
