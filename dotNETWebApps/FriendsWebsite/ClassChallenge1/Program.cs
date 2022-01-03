using ClassChallenge1.Services;
using ClassChallenge1.Models;
using ClassChallenge1.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection; //Needed to create Database?

//Tutorial here:
//https://docs.microsoft.com/en-us/aspnet/core/data/ef-mvc/intro?view=aspnetcore-6.0

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Used with dependency injection before the Database.
//builder.Services.AddSingleton<IFriendList, FriendList>();

builder.Services.AddControllersWithViews();

//Need to add service to talk to the database
//NOT NEEDED for ASP.NET Core 6.0. This is now in appsettings.json.
//string connectionString = "Server = JORMUNGANDR\\SQLEXPRESS;Database = Friends; Trusted_Connection = true;MultipleActiveResultSets = true";

//Transient says now FriendsList only exsists when requested instead of being there all the time with Singleton
builder.Services.AddTransient<IFriendList, FriendList>();

//Ensure that EntityFrameworkCore and EntityFrameworkCore.SQLServer NuGet packages are installed.
// Otherwise, options.UseSqlServer won't be available.
builder.Services.AddDbContext<FriendContext>(options =>
  options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

//Add database exception filter. Provides helpful error information:
builder.Services.AddDatabaseDeveloperPageExceptionFilter();


var app = builder.Build();




// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Friend}/{action=Index}/{id?}");

//See function below at the very end. Creates database if it doesn't exist.
CreateDbIfDoesntExist(app);

app.Run();

//Added to create the Database if it doesn't already exist.
static void CreateDbIfDoesntExist(IHost host)
{
    using (var scope = host.Services.CreateScope())
    {
        var services = scope.ServiceProvider;
        try
        {
            var context = services.GetRequiredService<FriendContext>();
            FriendInitializer.Initialize(context);
        }
        catch (Exception ex)
        {
            var logger = services.GetRequiredService<ILogger<Program>>();
            logger.LogError(ex, "An error occurred creating the DB.");
        }
    }
}