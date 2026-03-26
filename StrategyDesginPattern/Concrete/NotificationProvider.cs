using StrategyDesginPattern.Abstract;

namespace StrategyDesginPattern.Concrete
{
    public class NotificationProvider : INotificationProvider
    {
        private readonly Dictionary<string, INotificationStrategy> _strategies;

        public NotificationProvider(IEnumerable<INotificationStrategy> strategies)
        {
            _strategies = strategies.ToDictionary(s => s.Method, s => s, StringComparer.OrdinalIgnoreCase);
        }

        public INotificationStrategy GetStrategy(string method)
        {
            if (!_strategies.TryGetValue(method, out var strategy))
                throw new NotSupportedException($"{method} desteklenmiyor.");

            return strategy;
        }
    }
}
