=========================================================================================================== Asp.Net Core Partial View Result

Partial View: A partial view is a Razor view file (.cshtml) without a complete HTML structure. It is meant to be rendered as part of a parent’s view.
PartialViewResult: This is the action result returned by a controller action to render a partial view.


Some thing about Ajax Request:
The X-Requested-With header returns a string indicating whether it’s an AJAX request. An AJAX request will have this header set to XMLHttpRequest. 
This header value won’t be present for normal GET and POST Requests (non-Ajax requests).
Create a Custom class inheriting from the ActionMethodSelectorAttribute class and override the IsValidForRequest method. 
This is the method where we need to provide the custom logic for request validation. 
So, add a class file named AjaxOnlyAttribute.cs and then copy and paste the following code into it.