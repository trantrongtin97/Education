var builder = WebApplication.CreateBuilder(args);

//Add MVC services to container
builder.Services.AddMvc();

var app = builder.Build();

// Enable routing middleware, which matches incoming HTTP requests to endpoints defined in the application
app.UseRouting();

//Ways 1
// Map the default controller route (convention: {controller=Home}/{action=Index}/{id?})
// This means if no specific route is provided, it will default to HomeController and Index action
//app.MapDefaultControllerRoute();


//Ways 2: same ways 1
// Map the default controller route (convention: {controller=Home}/{action=Index}/{id?})
// This means if no specific route is provided, it will default to HomeController and Index action
app.MapControllerRoute(
    name: "default", // Name of the route
    pattern: "{controller=Home}/{action=Index}/{id?}" // URL pattern for the route
);


app.Run();
