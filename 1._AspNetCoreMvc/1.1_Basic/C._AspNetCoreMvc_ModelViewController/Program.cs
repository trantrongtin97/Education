using C._AspNetCoreMvc_ModelViewController.Models;
using C._AspNetCoreMvc_ModelViewController.Models.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add MVC services to the service container.
// This includes support for controllers and views.
builder.Services.AddMvc();



//Add Service to container
//Ways 1
builder.Services.Add(new ServiceDescriptor(typeof(IStudentRepository), new StudentRepository())); // default singleton
//builder.Services.Add(new ServiceDescriptor(typeof(IStudentRepository), typeof(StudentRepository),ServiceLifetime.Singleton)); // singleton
//builder.Services.Add(new ServiceDescriptor(typeof(IStudentRepository), typeof(StudentRepository), ServiceLifetime.Transient)); // singleton
//builder.Services.Add(new ServiceDescriptor(typeof(IStudentRepository), typeof(StudentRepository), ServiceLifetime.Scoped)); // singleton

//Ways 2
//builder.Services.AddSingleton<IStudentRepository, StudentRepository>();
//builder.Services.AddSingleton(typeof(IStudentRepository), typeof(StudentRepository));
//builder.Services.AddTransient<IStudentRepository, StudentRepository>();
//builder.Services.AddTransient(typeof(IStudentRepository), typeof(StudentRepository));
//builder.Services.AddScoped<IStudentRepository, StudentRepository>();
//builder.Services.AddScoped(typeof(IStudentRepository), typeof(StudentRepository));

var app = builder.Build();

app.UseRouting();

//Add this to use access controller and Action Method
//app.MapDefaultControllerRoute();

//Or Add this to use access controller and Action Method, and Default when run application
app.MapControllerRoute(
                name: "default", // Name of the route
                pattern: "{controller=Home}/{action=Index}/{id?}" // URL pattern for the route
            );

app.Run();
