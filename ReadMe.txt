=========================================================================================================== Asp.Net Core Action Result
Commom Types of Action Results

View Results:
	- ViewResult: When an action method returns a ViewResult, it renders a Razor view (.cshtml file) associated with the action method. 
	- PartialViewResult: We can also return a partial view using PartialViewResult, which is a subclass of ViewResult.

Content Results:
	- ContentResult: The ContentResult is useful for returning plain text or HTML directly from the action method without using views.
					It returns the result as a string in the response body.
	- JsonResult: The JsonResult in ASP.NET Core MVC Sends a JSON response. This is commonly used in AJAX applications. 
				  We can return this by calling Json() with an object that will be serialized into JSON format.

File Results:
	- FileResult: The FileResult in ASP.NET Core MVC returns binary file data to the client. We can return various file types using methods like File() 
					and specifying the file path or a byte array, along with the content type. 
					We can use it to return files, such as PDFs, images, etc.,to the client for downloading.

Redirect Results:
	- RedirectResult: Redirects to a specified URL. It is useful in scenarios where you want to redirect the user to an external URL.
	- RedirectToActionResult: Redirects to another action method within the same or different controller.
	- RedirectToRouteResult: This represents a response that redirects to a specific route configured in your application.

Status Results: HTTP status codes, We usually using main status
	- StatusCodeResult: Returns a specific HTTP status code.
	- BadRequestResult: Returns HTTP 400 Bad Request.
	- UnauthorizedResult: Returns HTTP 401 Unauthorized.
	- NotFoundResult: Returns a 404 Not Found status code.
	- OkResult: Returns a 200 OK status code.
	- NoContentResult: Returns HTTP 204 No Content status code.


What is MIME Type?
MIME types, which stand for “Multipurpose Internet Mail Extensions,” are standardized identifiers used to specify the nature and format of a file, 
document, or data being transferred over the Internet. Originally designed to expand the ability to send different kinds of data via email, 
MIME types now play an important role in web development and communication over the Internet, particularly in HTTP,
which defines the type of content being transmitted.

Image MIME Types:
	- JPEG: image/jpeg
	- PNG: image/png
	- GIF: image/gif
	- BMP: image/bmp
	- SVG: image/svg+xml
	- WebP: image/webp
Common File MIME Types:
	- PDF: application/pdf
	- Microsoft Word: application/msword
	- Microsoft Excel: application/vnd.ms-excel
	- Microsoft PowerPoint: application/vnd.ms-powerpoint
	- ZIP Archive: application/zip
	- JSON: application/json
	- XML: application/xml
	- Text: text/plain
	- HTML: text/html
Audio and Video MIME Types:
	- MP3 Audio: audio/mpeg
	- WAV Audio: audio/wav
	- OGG Audio: audio/ogg
	- MP4 Video: video/mp4
	- WebM Video: video/webm
	- OGG Video: video/ogg
	




