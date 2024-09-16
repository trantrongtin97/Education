=========================================================================================================== The Fisrt Lesson for Asp .Net Core
CreateBuilder() : To set Web Host with default preconfigured configurations as follows.
	1. Setting up the Web Server 
	2. Hosting the Web application
	3. Loading the Host and Application Configuration from various configuration sources 
	4. Configuring logging and many more services

ASP.NET Core Web application can be hosted in two ways : In Process, OutOfProcess
	In Process: (run with IS Express Profile) (default)				be host inside IIS Worker Process, w3wp.exe, and IIS..   (include proxy server(w3wp,IIS))
	OutOfProcess: (run with Application Name as the Launch Profile) be host :	Internal Web Server (Kestrel) (not include proxy server)
																				nen moi can them One External Web Server (IIS, Nginx, or Apache).. 

In Process improved performance than OutOfProcess. Because In Process Model, application code and IIS run in 1 memory space 
(not have communicate between the web server and the application process) 

Setting with: <AspNetCoreHostingModel>InProcess</AspNetCoreHostingModel> or Project-> Properties -> Debug - > Debug Launge profile UI
									OutOfProcess

LaunchSettings : In File launchSettings.json (in folder Properties)
	- Mỗi object json trong properties profiles note là 1 cấu hình cho 1 kiểu run application. vd http/https là chạy cho Kestrel Web Server

AppSetting: In File appsettings.json (in project)

UseDefaultFile will search wwwroot folder for file name:
index.htm
index.html
default.htm
default.html 

if you want to customer default name then using DefaultFilesOptions

Use Case:
	Use UseStaticFiles and UseDefaultFiles for basic static file serving and default file handling scenarios.
	Use UseFileServer when you need both static file serving and default file handling combined, along with directory browsing.
	UseDirectoryBrowser is optional and should be used cautiously, typically for debugging or specific requirements where directory contents need to be visible.




Applications using ASP.NET Core
	Angular, React, or React with Redux: These templates are set up to integrate with the respective JavaScript frameworks/libraries. 
										They include a basic setup that combines ASP.NET Core with Angular or React for building rich client-side interfaces.
	Blazor Server: Used for creating interactive Web UIs using C# instead of JavaScript. It runs on the server and communicates with the client side using SignalR.

	Blazor WebAssembly: This is similar to Blazor Server, but in this case, the application runs entirely on the client side in the browser using WebAssembly.

	Worker Service: This template creates background services and long-running processes without a UI.

	Console App: This is for creating a console application using .NET Core.

	Class Library: This is used to create a reusable set of classes, interfaces, and other functionalities that can be referenced from other applications.

	Minimal Web API: Introduced in .NET 6, this template allows you to create a minimalistic Web API project with fewer files and dependencies.