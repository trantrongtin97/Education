using _1._AspNetCore_WebApp_LayoutView_Section.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _1._AspNetCore_WebApp_LayoutView_Section.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        public ViewResult Details()
        {
            return View();
        }
    }
}
