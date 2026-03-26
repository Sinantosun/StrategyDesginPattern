using StrategyDesginPattern.Abstract;

namespace StrategyDesginPattern.Concrete
{
    public class EmailNotification : INotificationStrategy
    {
        public string Method => "Email";
        public async Task SendAsync(string to, string message)
        {
            // Gerçek SMTP kodları buraya gelir
            await Task.Delay(50);
            Console.WriteLine($"Email sent to {to}: {message}");
        }
    }
}
