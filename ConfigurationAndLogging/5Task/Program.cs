var builder = WebApplication.CreateBuilder(args);

// Додаємо підтримку контролерів з поданнями
builder.Services.AddControllersWithViews();

// Налаштування конфігурації для автоматичного оновлення
builder.Configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();