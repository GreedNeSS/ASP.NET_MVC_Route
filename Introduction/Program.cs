var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

app.MapDefaultControllerRoute();
app.MapFallbackToController("Error", "Home");

app.Run();
