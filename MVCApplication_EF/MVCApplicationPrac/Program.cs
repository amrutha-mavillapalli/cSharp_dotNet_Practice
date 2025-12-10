// namespace MVCApplicationPrac.Data;
using Microsoft.EntityFrameworkCore;
using MVCApplicationPrac.Data;
using MVCApplicationPrac.Models;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// Configuring the DbContext with SQL Server provider and connection string
// "DefaultConnection" is the name of the connection string defined in appsettings.json
// ApplicationDbContext is the custom DbContext class that manages the database connection and entity sets
// UseSqlServer method is used to specify that SQL Server is the database provider

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();  //routing middleware to route requests to appropriate controllers and actions
app.UseStaticFiles(); //to serve static files like CSS, JS, images from wwwroot

app.UseAuthorization();  //authorization middleware to enforce authorization policies

app.MapStaticAssets();

//defining a default route for the application
//This route pattern specifies that the URL will be in the format /{controller}/{action}/{id?}
// Routing middleware to route requests to appropriate controllers and actions
app.MapControllerRoute(  
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
