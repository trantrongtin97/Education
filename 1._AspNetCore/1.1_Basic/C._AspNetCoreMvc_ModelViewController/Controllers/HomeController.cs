using C._AspNetCoreMvc_ModelViewController.Models;
using C._AspNetCoreMvc_ModelViewController.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace C._AspNetCoreMvc_ModelViewController.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult AboutUs()
        {
            return View();
        }

        public ViewResult ContactUs()
        {
            return View("ContactUs");
            //return View("Views/Home/ContactUs.cshtml");
        }

        public ViewResult TestPath()
        {
            return View("~/Views/TestRootPath.cshtml");
        }

        //Manually Get Service
        //GetService method use to get service from DI Container
        public JsonResult GetStudentDetail(int id)
        {
            var services = this.HttpContext.RequestServices;
            IStudentRepository? _repository = (IStudentRepository?)services.GetService(typeof(IStudentRepository));
            Student? studentDetails = _repository?.GetStudentById(id);
            return Json(studentDetails);
        }
    }
}
