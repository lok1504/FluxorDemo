using FluxorDemo.Api.Hubs;
using FluxorDemo.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace FluxorDemo.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class NotificationController(
    IHubContext<NotificationHub> hubContext) : ControllerBase
{

    [HttpPost("SendMessage")]
    public async Task<IActionResult> SendMessage(string message)
    {
        if (string.IsNullOrEmpty(message))
        {
            return BadRequest("Message content is incomplete.");
        }

        var notificationMessage = new NotificationMessage()
        {
            Title = "Server Message",
            Message = message
        };

        await hubContext.Clients.All.SendAsync("ReceiveMessage", notificationMessage);

        return Ok(notificationMessage);
    }
}
