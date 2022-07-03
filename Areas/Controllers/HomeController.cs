using Microsoft.AspNetCore.Mvc;

namespace Areas.Controllers
{
    public class HomeController : Controller
    {
        // Вариант: #3
        [Route("{controller=Home}/{action=Index}/{Id?}")]
        public IActionResult Index()
        {
            return Content("HomeController вне области!");
        }
    }
}
