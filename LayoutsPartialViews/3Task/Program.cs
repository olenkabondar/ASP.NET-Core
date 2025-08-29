var builder = WebApplication.CreateBuilder(args);

// Додаємо служби MVC (Controllers with Views)
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Налаштування середовища
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // дозволяє використовувати CSS/JS/Bootstrap з wwwroot

app.UseRouting();

app.UseAuthorization();

// Налаштування маршрутизації
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();