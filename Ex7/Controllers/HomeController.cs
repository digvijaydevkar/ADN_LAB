using Microsoft.AspNetCore.Mvc;
using HelloMVC.Models;

namespace HelloMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Student student)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Form submitted successfully!";
                return View("Success");
            }
            return View(student);
        }

        public IActionResult Success()
        {
            return View();
        }
    }
}