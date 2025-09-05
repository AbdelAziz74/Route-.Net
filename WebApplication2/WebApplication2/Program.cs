namespace WebApplication2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            //builder.Services.AddControllers(); // API
            builder.Services.AddControllersWithViews(); // MVC
            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");

            app.MapControllerRoute(name: "default",
                pattern: "{controller}/{Action}/{id?}");
            app.Run();
        }
    }

}
