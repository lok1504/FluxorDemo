using FluxorDemo.Shared;

namespace FluxorDemo.Client.Features.NotificationHub;

public record ReceiveNotificationHubMessageAction(NotificationMessage Message);