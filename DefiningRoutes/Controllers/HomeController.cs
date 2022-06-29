using Microsoft.AspNetCore.Mvc;
using System;

namespace DefiningRoutes.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int? id)
        {
            string result = "Main Page.";
            if (id != null) result += $"\nId: {id}";
            return Content(result);
        }

        public IActionResult Info(string name, int age)
        {
            return Content($"Info Page.\nName: {name}, Age: {age}");
        }

        public IActionResult About()
        {
            return Content("About Page");
        }
    }
}
