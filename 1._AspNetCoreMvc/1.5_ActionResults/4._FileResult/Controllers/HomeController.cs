using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Headers;

namespace FileResult.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public Microsoft.AspNetCore.Mvc.FileResult DownloadFile()
        {
            string filePath = Directory.GetCurrentDirectory() + "\\wwwroot\\DownloadFiles\\" + "ttt.jpg";

            var fileBytes = System.IO.File.ReadAllBytes(filePath);
            var fileResult = File(fileBytes, "application/jpg");
            fileResult.FileDownloadName = "ttt.jpg";
            fileResult.LastModified = new DateTimeOffset(System.IO.File.GetLastWriteTimeUtc(filePath));
            fileResult.EntityTag = new EntityTagHeaderValue("\"fileVersion1\"");
            fileResult.EnableRangeProcessing = true;
            return fileResult;
        }

        public FileStreamResult DownloadFile2()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "DownloadFiles", "ttt.jpg");
            var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            var fileResult = new FileStreamResult(fileStream, "application/jpg")
            {
                FileDownloadName = "ttt.jpg",
                LastModified = new DateTimeOffset(System.IO.File.GetLastWriteTimeUtc(filePath)),
                EntityTag = new EntityTagHeaderValue("\"fileVersion2\""),
                EnableRangeProcessing = true
            };
            return fileResult;
        }

        public VirtualFileResult DownloadFile3()
        {
            string virtualFilePath = "/DownloadFiles/ttt.jpg";
            var fileResult = new VirtualFileResult(virtualFilePath, "application/jpg")
            {
                FileDownloadName = "ttt.jpg",
                // Optionally, set the last modified date of the file
                // LastModified = new DateTimeOffset(System.IO.File.GetLastWriteTimeUtc(filePath)),
                // Optionally, set the entity tag (ETag) for the file
                // EntityTag = new EntityTagHeaderValue("\"fileVersion1\""),
                // Enable range processing for the file
                // EnableRangeProcessing = true
            };
            return fileResult;
        }

        public PhysicalFileResult DownloadFile4()
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "DownloadFiles", "ttt.jpg");
            var fileResult = new PhysicalFileResult(filePath, "application/jpg")
            {
                FileDownloadName = "ttt.jpg",
            };
            return fileResult;
        }
    }
}
