using Microsoft.AspNetCore.Mvc;
using System;

namespace Attributes.Controllers
{
    public class HomeController : Controller
    {
        [Route("{controller=Home}/{action=Index}/{Id:int?}")]
        public IActionResult Index(int? id)
        {
            string result = "Home Page!";

            if (id is not null)
            {
                result += $"\nId: {id}";
            }

            return Content(result);
        }

        [Route("contacts")]
        [Route("about")]
        public string About()
        {
            return "About Page";
        }
    }
}
