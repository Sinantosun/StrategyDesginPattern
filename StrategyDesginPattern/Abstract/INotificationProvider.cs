namespace StrategyDesginPattern.Abstract
{
    public interface INotificationProvider
    {
        INotificationStrategy GetStrategy(string method);
    }
}
