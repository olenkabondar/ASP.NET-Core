using _1TaskStaticValue;

var builder = WebApplication.CreateBuilder(args);

// додаємо сесії
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseStaticFiles();
app.UseRouting();

// підключаємо сесії
app.UseSession();

// підключаємо middleware
app.UseMiddleware<OnlineUsersMiddleware>();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
