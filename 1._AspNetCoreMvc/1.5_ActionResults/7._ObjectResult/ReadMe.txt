=========================================================================================================== Asp.Net Core ObjectResult
Differences Between ObjectResult and OKResult

ObjectResult
	- It is used to return an HTTP response containing an arbitrary object that will be serialized and returned as the response body. 
		It’s commonly used to return data in various formats, such as JSON, XML, or other custom content types.
	- This can be used to return any status code, not just 200 OK. You can set different status codes based on your application’s requirements.
	==> If you need to return different status codes or provide custom content types, or if you are building more complex APIs

OKResult
	- It is specifically used to return a standard HTTP 200 (OK) response. 
	- It always returns a 200 OK status code suitable for explicitly indicating success.
	- This does not allow you to provide content to be serialized directly. It’s a simple way to indicate success without including a response body.