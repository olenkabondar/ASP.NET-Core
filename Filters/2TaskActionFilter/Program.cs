using _2TaskActionFilter.Filters;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

// Реєстрація фільтра як сервіс
builder.Services.AddScoped<LogActionFilter>(provider =>
    new LogActionFilter("action_log.txt"));

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
