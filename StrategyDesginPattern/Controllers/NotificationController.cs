using Microsoft.AspNetCore.Mvc;
using StrategyDesginPattern.Abstract;

[ApiController]
[Route("api/[controller]")]
public class NotificationController : ControllerBase
{
    private readonly INotificationProvider _provider;

    public NotificationController(INotificationProvider provider)
    {
        _provider = provider;
    }

    [HttpPost("send")]
    public async Task<IActionResult> SendNotification(string method, string to, string message)
    {
        var strategy = _provider.GetStrategy(method);
        await strategy.SendAsync(to, message);
        return Ok(new { Success = true, Provider = method });
    }
}