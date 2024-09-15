using AspNetCore_WebApp_Mvc_Attribute.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore_WebApp_Mvc_Attribute.Controllers
{
    public class StudentController : Controller
    {
        static List<Student> students = new List<Student>()
        {
            new Student() { Id = 1, Name = "TranTin" },
            new Student() { Id = 2, Name = "HuyLe" },
            new Student() { Id = 3, Name = "DinhPhuc" },
            new Student() { Id = 4, Name = "NT" }
        };

        public IActionResult Index()
        {
            return View();
        }

        [Route("Student/All")]
        public List<Student> GetAllStudents()
        {
            return students;
        }


        [Route("Student/{studentID}/Details")]
        public Student GetStudentByID(int studentID)
        {
            Student? studentDetails = students.FirstOrDefault(s => s.Id == studentID);
            return studentDetails ?? new Student();
        }
    }
}
