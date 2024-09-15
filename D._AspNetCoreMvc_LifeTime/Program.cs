using C._AspNetCoreMvc_DI_ModelViewController.Services;
using D._AspNetCoreMvc_DI_LifeTime.Models;
using D._AspNetCoreMvc_DI_LifeTime.Models.Interfaces;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMvc();

//builder.Services.AddSingleton<IStudentRepository, StudentRepository>();
//builder.Services.AddSingleton<TestingService>();

//builder.Services.AddScoped<IStudentRepository, StudentRepository>();
//builder.Services.AddScoped<TestingService>();

builder.Services.AddTransient<IStudentRepository, StudentRepository>();
builder.Services.AddTransient<TestingService>();

var app = builder.Build();
app.UseRouting();

app.MapControllerRoute(
                name: "default", 
                pattern: "{controller=Home}/{action=Index}/{id?}"
            );

app.Run();
