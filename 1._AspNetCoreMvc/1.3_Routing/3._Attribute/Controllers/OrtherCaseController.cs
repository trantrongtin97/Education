using Microsoft.AspNetCore.Mvc;

namespace Attribute.Controllers
{
    public class OrtherCaseController : Controller
    {
        [Route("MyHome")]
        [Route("MyHome/Index")]
        // ko the su dung OrtherCase/StartPage
        public string StartPage()
        {
            return "StartPage() Action Method of OrtherCaseController";
        }

        // OrtherCase/Privacy
        // ko the su dung MyHome/Privacy
        public string Privacy()
        {
            return "Privacy() Action Method of OrtherCaseController";
        }
    }
}
