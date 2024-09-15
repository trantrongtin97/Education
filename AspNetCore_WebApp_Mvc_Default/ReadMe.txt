=========================================================================================================== Asp.Net Core Routing
- Routing là cơ chế bắt cái request url http và mapping request đó đến các controller và cá action của nó
- Có 2 kiểu routing trong Asp .Net Core MVC
 + Convention Based Routing
 + Attribute-Based Routing

Cách hoạt động: 
 - Khi xưa, ASP.NET Web Form sử dụng các url dc map thằng vào các file vật lý (.aspx file) 
 vd như http://ttt/home.aspx dc chỉ thẳng đến file home.aspx từ đó render ra html trả về browser
 - Còn ở ASP.NET MVC bây giờ map cái url vào Controler và method
 vd như http://ttt/home/index dc chỉ thẳng đến file controller home và method index sau đó return view, nơi làm nhiệm vụ render html trả về browser
 - ASP.NET MVC lưu trữ các routes (URL và các thông tin đi kèm) trong RouteTable sau đó Routing engine sẽ dựa vào đó mà map đến controller và method
 - Mặc định khi tạo project Asp.Net core MVC sẽ có 2 middleware UseRouting và MapControllerRoute làm nhiệm vụ routing cho ứng dụng

Các Bước Hoạt Động:

	1.Registration of Route Templates (MapControllerRoute):
	- Làm nhiệm vụ đăng kí tất cả các mẫu route mình đăng kí vào RouteTable
	- Method này ko chạy mỗi lần reuqest đến, mà chỉ chạy khi khi ứng dụng khởi chạy
	- Method này ko trực tiếp làm nhiệm vụ handle map route các request mà nó set up 1 UseEndpoints Middleware để hanlder việc đó
	(Tức là tỏng method này đã chứa method UseEndpoints )

	Routing Middleware (UseRouting):
	- Làm nhiềm vụ khi 1 HTTP Request đến nó so sánh với các mẫu route trong RouteTable. N
	Nếu tìm thấy nó sẽ phân tích là request này gọi đến Controller nào, action nào, có parameter nào ko. và lưu vào HttpContext dưới RouteData
	Nếu ko tìm thấy nó sẽ trả về 404

	Determining the Controller and Action (UseEndpoints):
	- Sau khi UseRouting phân tích được url rồi nó sẽ ném cho UseEndpoints
	- Đây mới là nơi thật sự excute Controller và Action dc xác định ở UseRouting

Default Route Pattern URL: {controller=Home}/{action=Index}/{id?}

Route Constraints
 - Trong Default {controller=Home}/{action=Index}/{id:int?} . int? là Route Constraints
 - Có các kiểu Route Constraints
	int: Matches any integer.
	bool: Matches a Boolean value.
	datetime: Matches a valid DateTime value.
	decimal: Matches a decimal number.
	double: Matches a double number.
	guid: Matches a Guid value.
	long: Matches a long number.
	min(value): Matches an integer greater than or equal to the specified minimum value.
	max(value): Matches an integer less than or equal to the specified maximum value.
	range(min, max): Matches an integer within a specified range.
	alpha: Matches one or more alphabetical characters.
	regex(expression): Matches input based on the specified regular expression.
	length(min,max): Restricts the length of the parameter value.
