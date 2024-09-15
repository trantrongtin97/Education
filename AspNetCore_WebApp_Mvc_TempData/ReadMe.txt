=========================================================================================================== Asp.Net Core Web App Mvc - TempData
Giới hạn của ViewData và ViewBag là dữ liệu chỉ tồn tại ở scope lifetime ( mỗi HTPP Request)

TempData dc đẻ ra (  sử dụng lại dữ liệu ở subsequent HTTP Request ), chúng sẽ bị xóa khi chúng ta đọc chúng
- TempData là 1 thuộc tính nằm trong Controller abstract class thuộc kiểu ITempDataDictionary : IDictionary<string,object?>, cung cấp 5 method để sử dụng
	Load and Save : lấy và lưu dữ liệu từ HTTP Context
	Keep : Giữ cho tất cả dữ liệu trong TempData sống tiếp ở request tiếp theo, giúp chúng ko mất sao khi đọc
	Keep(string key) : Giữ cho 1 key sống, còn lại bị discarded.
	Peek(string key) : Đọc dữ liệu nhưng ko xóa nó đi