var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

#region Configuring Default Page, Static File 

//this way Default custom page must have UseDefaultFiles() and UseStaticFiles()
//DefaultFilesOptions defaultFilesOptions = new DefaultFilesOptions();
//defaultFilesOptions.DefaultFileNames.Clear();
//defaultFilesOptions.DefaultFileNames.Add("TTTCustomDefaultPage.html");
//app.UseDefaultFiles(defaultFilesOptions);
//app.UseStaticFiles();

//this way Default custom page no have UseDefaultFiles() and UseStaticFiles()
//FileServerOptions fileServerOptions = new FileServerOptions();
//fileServerOptions.DefaultFilesOptions.DefaultFileNames.Clear();
//fileServerOptions.DefaultFilesOptions.DefaultFileNames.Add("TTTCustomDefaultPage.html");
//app.UseFileServer(fileServerOptions);

//app.UseDefaultFiles();  //use index.html to default page, must use UseStaticFiles 
//app.UseStaticFiles();  //use wwwroot folder -> see image when localhost:{port}/aa.jpg and can be use UseDefaultFile

// Enable directory browsing on the current path
app.UseDirectoryBrowser();

#endregion


#region Middleware Component

//app.MapGet("/", () => "Hello World!");

//// Maps HTTP GET requests to "/greet" URL to a method returning a greeting message
//app.MapGet("/greet", () => "Hello from the /greet endpoint!");

//// Maps HTTP GET requests to "/greet/{name}" URL to a method that uses a route parameter
//app.MapGet("/greet/{name}", (string name) => $"Hello, {name}!");

//app.MapGet("/", () => $"Hello World! {System.Diagnostics.Process.GetCurrentProcess().ProcessName}");

//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("Getting Response from First Middleware");
//});

#endregion


#region Developer Exception Page

//Default setting Exception Page
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();  // default asp.net core have this middleware
}

//Custom setting Exception Page
//if (app.Environment.IsDevelopment())
//{
//    //Create an Instance of DeveloperExceptionPageOptions to Customize
//    //UseDeveloperExceptionPage Middleware Component
//    DeveloperExceptionPageOptions developerExceptionPageOptions = new DeveloperExceptionPageOptions
//    {
//        SourceCodeLineCount = 5
//    };
//    //Passing DeveloperExceptionPageOptions Instance to UseDeveloperExceptionPage Middleware Component
//    app.UseDeveloperExceptionPage(developerExceptionPageOptions);
//}

//app.MapGet("/", async context =>
//{
//    int Number1 = 10, Number2 = 0;
//    int Result = Number1 / Number2; // execption
//    await context.Response.WriteAsync($"Result : {Result}");
//});

#endregion


#region File LaunchSettings and AppSetting

//get custom variable key from appsetting file: has 2 ways
//way 1:
string tttKey = builder.Configuration.GetValue<string>("TTTKey", "");
//way 2:
ConfigurationManager configuration = builder.Configuration;
string? MyCustomKeyValue = builder.Configuration["TTTKey"];

#endregion


app.Run();

