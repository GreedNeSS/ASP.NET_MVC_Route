using Microsoft.AspNetCore.Routing.Constraints;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{Id:int?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{Id?}",
    constraints: new { Id = new IntRouteConstraint()});

app.MapControllerRoute(
    name: "defExample",
    pattern: "default/example",
    defaults: new {controller = "Home", action = "Info", name = "GreedNeSS", age = 30});

app.MapControllerRoute(
    name: "info",
    pattern: "{controller}/{action}/{name}/{age:int}");

app.MapControllerRoute(
    name: "action",
    pattern: "{action}",
    defaults: new { controller = "Home" });

app.Run();
