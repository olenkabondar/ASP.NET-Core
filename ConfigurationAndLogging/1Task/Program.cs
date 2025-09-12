using _1Task.Models;

var builder = WebApplication.CreateBuilder(args);

// Додаємо підтримку контролерів з поданнями
builder.Services.AddControllersWithViews();

// Прив'язка конфігурації до класу
builder.Services.Configure<MessageConfig>(
    builder.Configuration.GetSection("MessageConfig"));

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
