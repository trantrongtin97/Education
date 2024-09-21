using C._AspNetCoreMvc_ModelViewController.Models;
using C._AspNetCoreMvc_ModelViewController.Models.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace C._AspNetCoreMvc_Controller.Controllers
{
    public class DemoController : Controller
    {
        private readonly IStudentRepository _repository;
        public DemoController(IStudentRepository repository)
        {
            _repository = repository;
        }

        //https://localhost:44385/demo/GetName
        public string GetName()
        {
            return "Trần Trọng Tín";
        }

        //https://localhost:44385/demo/GetByName?name=Tin
        public string GetByName(string name)
        {
            return $"Name : {name}";
        }

        //https://localhost:44385/Demo/GetStudentDetails/1
        //Without Dependency Injection
        public JsonResult GetStudentDetails(int Id)
        {
            StudentRepository repository = new StudentRepository();
            Student studentDetails = repository.GetStudentById(Id);
            return Json(studentDetails);
        }

        //https://localhost:44385/Demo/GetStudentDetails2/1
        //With Dependency Injection
        public JsonResult GetStudentDetails2(int Id)
        {
            Student studentDetails = _repository.GetStudentById(Id);
            return Json(studentDetails);
        }
    }
}
