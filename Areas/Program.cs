var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

// Вариант: #1
//app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{Id?}");
//app.MapControllerRoute("Account", "{area:exists}/{controller=Home}/{action=Index}/{Id?}");

// Вариант: #2
//app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{Id?}");
//app.MapAreaControllerRoute(
//    name: "Account",
//    areaName: "Account",
//    pattern: "profile/{controller=Home}/{action=Index}/{Id?}");

// Вариант: #3
app.MapControllers();

app.Run();
