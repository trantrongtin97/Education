=========================================================================================================== Set Up Asp .Net Core MVC

Differences between AddController, AddMvc, AddControllersWithViews, and AddRazorPages in Summary.png Image
	- Controler : kiểm soát luồng thực thi ứng dụng
	- Model Binding: Các HTTP request data (Route Data, Query String Data, Request Body Data, Posted form Data, etc.) sẽ được mapping vào các tham số trong controller
	- API Explorer: là các action của controller (get,post,put,delete), Response Type
	- Authorization: Xác thực, Ủy Quyền
	- CORS: Cross-Origin Resource Sharing - Cho phép các domain khác có thể thuy cập vào domain của mình thông qua jquery AJAX
	- Validation: Kiểm tra tính đúng sai dữ liệu
	- Formatter Mapping: Cho phép thay đổi định dạng đầu ra của các action ( Json, XML)
	- Antiforgery: Ngăn chặn tấn công CSRF (Cross-Site Request Forgery) , ở ASP .NET CORE sử dụng verification tokens để ngăn chặn 
	- TempData: Lưu trữ dữ liệu tạm lại cho các request tiếp theo
	- Views: Là các view trong MVC đó
	- Pages: Là 1 page của 1 web đó
	- Tag Helpers: Cho phép Server-side rendering to HTML elements
	- Memory Cache: Lưu trữ dữ liệu trên server memory, giúp cải thiện hiệu suất vì lưu trữ các dữ liệu dc sử dung thường xuyên và sử dụng lại


When using which ?
	- Web API Application: AddControllers()
	- Razor Pages Application: AddRazorPages() 
	- Web Application using the Model View Controller Design Pattern : AddControllersWithViews() , và nếu muốn thêm các tính năng của Razor Pages nữa thì AddMVC()

=> AddMVC() có tất cả các tính năng, vì thế có thể sử dụng nó cho tất cả application của ta (Web API, MVC, and Razor Pages). 
	Nhưng vì nó thêm vào tất cả nên nếu thật sự ko sử dụng hết toàn bộ thì có thể sẽ ảnh hưởng đến hiệu năng của ứng dụng
