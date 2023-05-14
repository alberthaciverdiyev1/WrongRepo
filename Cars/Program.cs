using Cars.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(x => x.UseSqlServer(builder.Configuration.GetConnectionString("Default")));
var app = builder.Build();
app.UseStaticFiles();

app.MapControllerRoute(
    name: "Default",
    pattern: "{area:exists}/{Controller=home}/{action=index}/{id?}");


app.MapControllerRoute(
    name:"Default",
    pattern:"{Controller=home}/{action=index}/{id?}");

app.Run();
