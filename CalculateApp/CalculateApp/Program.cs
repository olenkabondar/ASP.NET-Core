var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    // Маршрут для калькулятора з двома параметрами
    endpoints.MapControllerRoute(
        name: "Calc",
        pattern: "Calc/{action}/{a}/{b}",
        defaults: new { controller = "Calc" });

    endpoints.MapControllerRoute(
        name: "Default",
        pattern: "{controller=Calc}/{action=Index}/{id?}");
});

app.Run();
