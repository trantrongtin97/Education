=========================================================================================================== Asp.Net Core MVC Model - View - Controller
	- Controller có nhiệm vụ tiếp nhận các HTTP Request sau đó làm làm việc với các Model và trả về View để render
	- Khi ở client (Browser) gữi request lên server, các request đó đầu tiên sẽ đi vào pipeline ( tức là các Middleware bên trong Pipeline), sau đó sẽ đến controller
	- Trong controller, có nhiều action (hay gọi là các action method) nó sẽ tiếp tục tiếp nhận các HTTP Request, 
		các action sẽ thực hiện các business logic và phản hồi lại client

Rule of Controller
	- Naming Convention: Phải có chữ "Controller" phía sau
	- Inheriting from ControllerBase: Phải kế thừa từ abstract class Controller : từ ControllerBase trong Microsoft.AspNetCore.Mvc

Các Method trong controller dc gọi là các Action Method
Để gọi 1 Action Method chúng ta gọi qa Url vd: http:domain.com/ControllerName/ActionMethodName.
Mặc định 1 project Asp.Net Core sẽ ko thể tự nhận biết để bắt dc khi mình gọi controller và các action method

Vậy khi nào Controller dc khởi tạo (Create Instance)
	- Khi 1 Request dc gọi đến server, chạy pipeline MVC Middleware (AddMVC(),app.MapControllerRoute(),app.MapDefaultControllerRoute()), 
		nó sẽ biết dc Controller nào dc gọi và Action Method nào dc chọn từ đó khởi tạo đúng controller và thực thi Method dc gọi
		DefaultControllerActivator, IControllerActivator sẽ là class thực hiện việc khởi tạo Controller
		Gồm 3 hàm : Create, Release, and ReleaseAsync
			- Create: Hàm create instance controller ( Sau này chúng ta có thể sử dụng hàm này để chủ động khởi tạo 1 controller mà ko thông qa MVC)
			- Release, ReleaseAsync: Hàm này cung cấp controller để sử dụng cũng như dọn dẹp, loại bỏ controller ko cần thiết
		==> Khi Application dc chạy, Asp.Net Core sẽ khởi tạo tất cả các Controller hiện có và giữ chúng ở DefaultControllerActivator bằng hàm Create(), 
			và khi 1 request gọi đến Controller để thực thi Action Method. DefaultControllerActivator sẽ cấp phát sử dụng thông qa hàm Release() or ReleaseAsync()
			cũng như thu hồi, dọn dẹp Controller đó khi dc sử dụng xog

Models
	- Là nơi chứa các domain data (business data), logic data (validation, business, and data access logic) nói chung là để quản lí dữ liệu
Views
	- View là nơi tiếp nhận dữ liệu từ controller và render cho user. Views là các file ".cshtml" (cs + html). View biên dịch code c# và html trên cùng 1 file rồi gữi lại cho user
	- Có các loại view :
		Razor Views: Loại hay xài nhất trong MVC. sự dụng cú pháp Razor. Cú pháp này là giúp biên dịch C# và html trên cùng 1 file
		Partial Views: là các view có thể tái sử dụng, có thể nhúng vào các view khác
		View Components: Đơn giản nó là partial view nhưng xịn hơn, có chứa cả các logic
		Layout Views: Là các view có thể tái sử dụng, dùng là các thành phần chung để duy trì giao diện thống nhất ( giống master page bên Web Form)
	
	- Các view sẽ nằm trong folder Views/[ControllerName]/[ViewName].cshtml. Default view của 1 controller là index


Dependency Injection trong ASP .NET Core

Có 2 loại service trong ASP .NET Core:
	- Framework Service: là các service có sẵn trong trong ASP .NET Core (IApplicationBuilder, IHostingEnvironment, ILoggerFactory ,...)
	- Application Service: là các service chúng ta tạo ra 

Để DI các serivice trong ASP .NET Core ta phải Ioc chúng trong Program file trong Main class

