using Serilog;

var builder = WebApplication.CreateBuilder(args);

// Налаштування Serilog для логування у Seq
Log.Logger = new LoggerConfiguration()
    .Enrich.FromLogContext()
    .WriteTo.Seq("http://localhost:5341") // URL вашого Seq
    .CreateLogger();

// Використання Serilog як логера для всього додатку
builder.Host.UseSerilog();

builder.Services.AddControllersWithViews();

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
