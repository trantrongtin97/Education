=========================================================================================================== Asp.Net Core File Result
Properties of FileResult Class:
	- ContentType: The ContentType property specifies the file’s MIME type. This tells the browser what kind of file is being sent so it can handle it appropriately. 
	- FileDownloadName: This property is used to suggest a filename when the client downloads the content. If this property is set, 
		the browser uses it as the default name for the file when saving it to disk. If not set, the file will be saved using the filename in the URL 
		or without a specific name, depending on browser behavior and the URL used to access the resource. 
	- LastModified: The LastModified property indicates the file’s last modified date and time. This can be used for caching purposes. 
		If the file hasn’t changed since the last time the client requested it, the client can use a cached version instead of downloading it again. 
		The server includes this timestamp in the HTTP response headers to support conditional requests using the Last-Modified header.
	- EntityTag: The EntityTag (ETag) property is another mechanism for caching. It’s a unique identifier representing the specific version of the file. 
		If the ETag matches the one the client has, the client can use the cached version.
	- EnableRangeProcessing: The EnableRangeProcessing property allows for partial content responses, which is useful for large files. 
		This enables the client to request only a specific part of the file, which is particularly useful for streaming media files.


Types of FileResult:
	- FileContentResult: This result type uses a byte array to send file content directly to the response.
	- FileStreamResult: This type uses a Stream object to send file content, which is useful for large files.
	- VirtualFileResult: This result serves a file specified by a virtual path, allowing the file to reside anywhere 
						in the application’s content root or web root.
	- PhysicalFileResult: PhysicalFileResult returns a file directly from a physical file path on disk. 
						It is suitable for serving files from a specific path on the server’s file system.

FileContentResult: Binary content 
FileStreamResult: File content from a Stream (for streaming large files)
VirtualFileResult: Writes it directly to the HTTP response’s output stream (not convert byte array or stream)
PhysicalFileResult: Opens a read stream for the specified file and writes it directly to the HTTP response’s output stream

Compare VirtualFileResult vs PhysicalFileResult
	VirtualFileResult: Used when you want to return a file from a virtual path. This path is relative to the web root directory of your application. 
						It is typically used for files stored within the application’s directory structure. 
						It is useful when you are working with files within your web application’s content directory 
						(like wwwroot or other folders configured as part of your application’s web root).
	PhysicalFileResult: Used when you want to return a file from an absolute physical path on the server. 
						 This path can be outside the web root directory and can be any valid path on the server where the application has access permissions. 
						 It is suitable when you need to serve files stored outside the web application’s root directory, 
						 such as files in a different directory on the server.

==> VirtualFileResult use file in root directory 
	PhysicalFileResult use file outside root directory, can be any valid path on the server where the application has access permissions





