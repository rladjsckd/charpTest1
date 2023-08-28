using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;

namespace EmptyBootstrap01
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");
            app.UseStaticFiles();
            app.MapControllerRoute(
                name: "deault",
                pattern:"{controller:Home}/{action:Index}{id?}"
                );
            app.Run();
        }
    }
}
