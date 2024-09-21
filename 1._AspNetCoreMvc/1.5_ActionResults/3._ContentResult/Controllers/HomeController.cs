using ContentResult.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Newtonsoft.Json;

namespace ContentResult.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public Microsoft.AspNetCore.Mvc.ContentResult Index()
        {
            string plainText = "This is plain text content.";
            return new Microsoft.AspNetCore.Mvc.ContentResult
            {
                // Set the ContentType property to "text/plain" to indicate the MIME type of the content
                ContentType = "text/plain",
                // Set the Content property to the plainText string, which contains the content to be returned
                Content = plainText
            };
        }

        public Microsoft.AspNetCore.Mvc.ContentResult Index2()
        {
            string plainText = "This is plain text content.";
            // Return a ContentResult using the Content method of the base Controller class
            // The Content method is a helper method that creates a ContentResult with the specified content and content type
            return Content(plainText, "text/plain");
        }

        public Microsoft.AspNetCore.Mvc.ContentResult Index3()
        {
            string htmlContent = "<html><body><h1>Text HTML</h1></body></html>";
            // Return a ContentResult using the Content method of the base Controller class
            // The Content method is a helper method that creates a ContentResult with the specified content and content type
            // The first parameter is the HTML content to be written to the response body
            // The second parameter is the content type, set to "text/html" to indicate that the response's content type is HTML
            return Content(htmlContent, "text/html");
        }

        public Microsoft.AspNetCore.Mvc.ContentResult Index4()
        {
            string xmlContent = "<?xml version=\"1.0\" encoding=\"UTF-8\"?><data><item>Text XML</item></data>";
            // The first parameter is the XML content to be written to the response body
            // The second parameter is the content type, set to "application/xml" to indicate that the response's content type is XML
            return Content(xmlContent, "application/xml");
        }

        public Microsoft.AspNetCore.Mvc.ContentResult Index5()
        {
            var jsonData = new { Name = "TTT", Age = 27, Occupation = "Dev" };
            var jsonSerializedString = JsonConvert.SerializeObject(jsonData);
            // Return a ContentResult using the Content method of the base Controller class
            // The first parameter is the JSON string to be written to the response body
            // The second parameter is the content type, set to "application/json" to indicate that the response's content type is JSON
            return Content(jsonSerializedString, "application/json");
        }

        public Microsoft.AspNetCore.Mvc.ContentResult Index6()
        {
            string content = "This is a simple string.";
            // Return a ContentResult using the Content method of the base Controller class
            // The Content method is a helper method that creates a ContentResult with the specified content
            // In this case, only the content string is provided, and the content type defaults to "text/plain"
            return Content(content);
        }

        public Microsoft.AspNetCore.Mvc.ContentResult Index7()
        {
            string customContent = "Custom content with specific settings.";
            return new Microsoft.AspNetCore.Mvc.ContentResult
            {
                Content = customContent,
                ContentType = "text/plain",
                StatusCode = 200, 
            };
        }
    }
}
