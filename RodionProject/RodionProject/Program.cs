namespace RodionProject;

public class Program
{
    public static void Main(string[] args)
    {
        Environment.SetEnvironmentVariable("ASPNETCORE_URLS", "http://0.0.0.0:5000");

        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllersWithViews();

        var app = builder.Build();

        app.UseStaticFiles();

        app.UseRouting();
        
        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}