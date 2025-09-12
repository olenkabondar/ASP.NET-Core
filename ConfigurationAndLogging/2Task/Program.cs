using _2Task.Models;
using _2Task.Services;

var builder = WebApplication.CreateBuilder(args);

// ASP.NET Core автоматично підвантажує appsettings.json
// + appsettings.{Environment}.json
// залежно від змінної середовища ASPNETCORE_ENVIRONMENT

builder.Services.AddControllersWithViews();

builder.Services.Configure<EmailSettings>(
    builder.Configuration.GetSection("EmailSettings"));

builder.Services.AddTransient<EmailService>();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=SendEmail}/{id?}");

app.Run();
