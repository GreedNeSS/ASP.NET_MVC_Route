using Microsoft.AspNetCore.Mvc;
using System;

namespace Introduction.Controllers
{
    public class HomeController : Controller
    {
        public string Index()
        {
            var controller = RouteData.Values["controller"];
            var action = RouteData.Values["action"];
            return $"Home Page!\nController: {controller}; Action: {action}";
        }

        public string Error()
        {
            return "Error Page!";
        }
    }
}
