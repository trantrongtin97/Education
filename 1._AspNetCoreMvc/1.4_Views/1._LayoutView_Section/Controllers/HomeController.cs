using LayoutView_Section.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace LayoutView_Section.Controllers
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
