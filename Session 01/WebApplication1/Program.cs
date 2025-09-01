namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();

            builder.Services.AddControllersWithViews();

            #region ConfigureServices => builder.Services
            // builder.Services.Add();

            #endregion

            #region Configure
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler();
            }

            app.UseRouting();
            app.MapGet("/", async context =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
            #endregion
            

            app.Run();
        }
    }
}
