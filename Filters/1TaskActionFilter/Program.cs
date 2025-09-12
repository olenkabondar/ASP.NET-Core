using _1TaskActionFilter.Filters;

var builder = WebApplication.CreateBuilder(args);

// Додаємо MVC
builder.Services.AddControllersWithViews();

// Реєструємо фільтр як сервіс (щоб використовувати [ServiceFilter])
builder.Services.AddScoped<UniqueUserCounterFilter>(provider =>
    new UniqueUserCounterFilter("unique_users.txt"));

var app = builder.Build();

// Стандартні middleware для обробки HTTP
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Маршрути MVC
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();