namespace RedirectResult
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

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
                name: "AboutUsRoute",
                pattern: "about",
                defaults: new { controller = "Home", action = "About" }
            );
            app.MapControllerRoute(
                name: "AboutNameRoute",
                pattern: "about",
                defaults: new { controller = "Home", action = "AboutWithName" }
            );
            app.MapControllerRoute(
                name: "AboutAgeName",
                pattern: "about",
                defaults: new { controller = "Home", action = "AboutWithAgeAndName" }
            );

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
