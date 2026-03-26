using StrategyDesginPattern.Abstract;

namespace StrategyDesginPattern.Concrete
{
    public class SmsNotification : INotificationStrategy
    {
        public string Method => "SMS";
        public async Task SendAsync(string to, string message)
        {
            // sms servis entegrasyonu
            await Task.Delay(50);
            Console.WriteLine($"SMS sent to {to}: {message}");
        }
    }
}
