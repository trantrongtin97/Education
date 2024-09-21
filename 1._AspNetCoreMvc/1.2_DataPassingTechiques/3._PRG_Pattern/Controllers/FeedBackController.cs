using PRG_Pattern.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace PRG_Pattern.Controllers
{
    public class FeedBackController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePOST(FeedBack feedback)
        {
            if (ModelState.IsValid)
            {
                // Or save vo database
                TempData["SuccessMessage"] = "Thank you for your feedback!";
                string json = JsonSerializer.Serialize(feedback);
                TempData["feedback"] = json;
                return RedirectToAction("Confirmation");
            }
            return View(feedback);
        }

        [HttpGet]
        public IActionResult Confirmation()
        {
            TempData.Keep("feedback");
            return View();
        }

        [HttpGet]
        public IActionResult Index()
        {
            FeedBack student = null;
            if (TempData.ContainsKey("feedback"))
            {
                var str = TempData["feedback"];
                student = JsonSerializer.Deserialize<FeedBack>($"{str}"); 
            }
            
            return View("Index", student ?? new FeedBack());
        }
    }
}
