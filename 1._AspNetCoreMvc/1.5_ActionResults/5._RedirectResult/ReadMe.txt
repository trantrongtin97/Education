=========================================================================================================== Asp.Net Core RedirectResult
When Use:
	- RedirectResult: When you need to redirect to an absolute URL. For example, redirecting to an external website or an absolute URL within your application.
	- RedirectToRouteResult: When you need to redirect to a specific route by specifying route values. 
							This is useful when you want to dynamically determine the route to redirect to based on the route configuration. 
							For example, redirecting to a URL by specifying route parameters dynamically.
	- RedirectToActionResult: When you need to redirect to a specific action within your application. 
							This is the most common type of redirect used in ASP.NET Core MVC because it allows you to specify the controller 
							and action you want to redirect to directly. For example, Redirecting to another action within the same controller 
							or a different controller.