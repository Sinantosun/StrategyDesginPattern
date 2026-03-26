using StrategyDesginPattern.Abstract;
using StrategyDesginPattern.Concrete;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<INotificationStrategy, EmailNotification>();
builder.Services.AddSingleton<INotificationStrategy, SmsNotification>();
builder.Services.AddSingleton<INotificationProvider, NotificationProvider>();
builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
