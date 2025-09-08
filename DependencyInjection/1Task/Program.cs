using _1Task.Models;

var builder = WebApplication.CreateBuilder(args);

//обираємо який сервіс реєструвати
//builder.Services.AddScoped<IStringService, DaysService>();   // для днів
builder.Services.AddScoped<IStringService, MonthsService>(); // для місяців

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();
app.MapDefaultControllerRoute();

app.Run();