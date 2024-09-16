=========================================================================================================== Asp.Net Core Web App Mvc - Template
Project File and Folder Structure:
	- Connected Services: Dùng để kết nối với các service bên ngoài như Azure, Offcice 365, REST APIs,.. 
	- Dependencies Folder: Chứa các NuGet packages và các dependencies 
		Packages: Chứa các NuGet packages.
		SDKs: Chứa các .NET SDKs.
		Projects: Chứa các project dc refrence đến project hiện tại.
	- wwwroot Folder: Chứa tất cả các file static trong application như (css file, javascript, image,..). Truy cập vào các tệp này bằng url
	- Controllers Folder: Chưa các controller
	- Models Folder: Chứa Model data, Validation, bussiness logic, data access logic
	- Views Folder: Chưa các file chứa nội dung html. Trong đó có các sub folder tương ứng với các controller
	- Shared Folder: Chưa các View và các Patial View sử dụng ở nhiều nơi như các layout, Error page,.. Shared Folder thường nằm trong Views 
	- _ViewStart.cshtml File : là 1 View Đặc biệt chạy đầu tiên trc mọi View khi ứng dụng dc run. Được sử dụng để định nghĩa cài đặt của tất cả các view
	- _ViewImports.cshtml File: Cho phép mình thêm các namespaces, Razor directives muốn add vào tất cả các view 
		@using cho khai báo namespaces 
		@inject cho dependency injection
		@model cho khai báo các model
		Việc này giúp mình ko cần phải add đi add lại các thứ này ở mỗi view sau này
	- appsettings.json File : Là file Json Chứa các setting cho ứng dụng ( connection string, framework configuration settings, logging, and custom application settings)
	- Program.cs File: Là nơi khởi chạy cả ứng dụng. Là set up Host, Service, logginh, sources, http và các pipeline

=========================================================================================================== Asp.Net Core Web App Mvc - ViewData

==== View Data
- ViewData là 1 kiểu đối tượng dictionary cho phép truyền dữ liệu từ các Action Method đến View.
- ViewData là 1 thuộc tính nằm trong Controller abstract class thuốc kiểu ViewDataDictionary : IDictionary<string,object?>
- Error when Compile-time
- Scope Lifetime

==== View Bag
- ViewBag là 1 kiểu Dynamic type.
- ViewBag là 1 thuộc tính nằm trong Controller abstract class thuộc kiểu DynamicViewData
- Not Error when Compile-time (NullReferenceException in Runtime)
- Scope Lifetime

=======> Chúng ta có thể set data bằng ViewData và get bằng cách ViewBag và ngược lại.

==== Strongly Type
- Sử dụng ViewResult để truyền dữ liệu
- Trong thực tế chúng ta sử dụng cách này nhưng ko sử dụng trực tiếp model chính àm thông qa 1 lớp trung gian có thể chứa dc nhiều data hơn -  chính là ViewModel

