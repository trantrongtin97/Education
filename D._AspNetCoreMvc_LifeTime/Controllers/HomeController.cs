using C._AspNetCoreMvc_DI_ModelViewController.Services;
using D._AspNetCoreMvc_DI_LifeTime.Models;
using D._AspNetCoreMvc_DI_LifeTime.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace D._AspNetCoreMvc_DI_LifeTime.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentRepository? _repository;
        private readonly TestingService? _testingService;
        public HomeController(IStudentRepository repository,TestingService testingService)
        {
            _repository = repository;
            _testingService = testingService;
        }
        public JsonResult Index()
        {
            List<Student>? allStudentDetails = _repository?.GetAllStudent();
            _testingService?.SomeMethod();
            return Json(allStudentDetails);
        }

        public JsonResult GetStudentDetail(int id)
        {
            Student? studentDetails = _repository?.GetStudent(id);
            _testingService?.SomeMethod();
            return Json(studentDetails);
        }
    }
}
