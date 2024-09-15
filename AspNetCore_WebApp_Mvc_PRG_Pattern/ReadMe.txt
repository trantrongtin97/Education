=========================================================================================================== Asp.Net Core Post-Redirect-Get (PRG) Pattern

 - POST (Form Submission): Khi user submit form, dữ liệu dc send qa Post đến server và server xử sau đó trả kết qả lại.
 - Redirect (PRG Step): Thay vì trả về 1 trang html như bt, server sẽ chuyển hướng đến 1 url khác (thường mã code là 302)
 - GET (Response Retrieval): Browser sẽ dựa theo url đó để thực hiện GET chuyển hướng trang