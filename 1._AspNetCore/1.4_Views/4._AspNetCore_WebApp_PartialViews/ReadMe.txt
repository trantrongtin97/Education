=========================================================================================================== Asp.Net Core Partial Views
Method to render a partial view to main view:

Method 1: Using Html.Partial
	- @Html.Partial(“_PartialViewName”)
	- @Html.Partial(“_PartialViewName”, model)

Method 2: Using Html.PartialAsync
	- @await Html.PartialAsync(“_PartialViewName”)
	- @await Html.PartialAsync(“_PartialViewName”, model)

Method 3: Using Html.RenderPartial
	- @{ Html.RenderPartial(“_PartialViewName”); }
	- @{ Html.RenderPartial(“_PartialViewName”, model); }

Method 4: Using Html.RenderPartialAsync
	- @{ await Html.RenderPartialAsync(“_PartialViewName”); }
	- @{ await Html.RenderPartialAsync(“_PartialViewName”, model); }

Method 5: Using Tag Helpers
	- <partial name=”_MyPartialView” model=”Model.PartialData” />



Different Ways to Render Partial View:

	- Html.Partial: Used to render view synchronously. Insert html of partital view in to parent view. We can store return html into variable.
					Method usually use when data use in partial view is already avaiable in parent view

	- Html.PartialAsync: Like Partial but in asynchronous 
						 Use when need perform asynchronous partial view such as database call, file I/O...

	- Html.RenderPartial: Similar to Html.Partial but the key difference is RenderPartial not return HTML, instead to HTTP Reponse (void method)
	- Html.RenderPartialAsync: Like RenderPartial but in asynchronous

	- Partial Tag Helper: Render partial view in html syntax. Allow we include a partial view into another view. it run async mode

Note:	Using method in async mode have good performace than.
		Only data already and all processing complete quickly, we should use Html.Partial, Html.RenderPartial
