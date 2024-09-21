using ViewImport.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ViewImport.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            List<Student> listStudents = new List<Student>()
            {
               new Student() { StudentId = 101, Name = "TTT", Branch = "T", Section = "A", Gender = "Male" },
               new Student() { StudentId = 102, Name = "DD", Branch = "D", Section = "B", Gender = "Male" },
               new Student() { StudentId = 103, Name = "YYYY", Branch = "Y", Section = "A", Gender = "Male" },
               new Student() { StudentId = 104, Name = "VVVV", Branch = "V", Section = "A", Gender = "Female" },
               new Student() { StudentId = 105, Name = "LLLL", Branch = "L", Section = "B", Gender = "Female" }
            };
            return View(listStudents);
        }
        public ViewResult Details(int Id)
        {
            var studentDetails = new Student() { StudentId = Id, Name = "TTT", Branch = "T", Section = "A", Gender = "Male" };
            return View(studentDetails);
        }
    }
}
