namespace StrategyDesginPattern.Abstract
{
    public interface INotificationStrategy
    {
        string Method { get; }
        Task SendAsync(string to, string message);
    }
}
