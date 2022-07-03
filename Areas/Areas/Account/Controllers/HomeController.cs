using Microsoft.AspNetCore.Mvc;

namespace Areas.Areas.Account.Controllers
{
    [Area("Account")]
    public class HomeController : Controller
    {
        // Вариант: #3
        [Route("{area}")]
        [Route("profile")]
        [Route("{area}/{controller}")]
        [Route("{area}/{controller}/{action}")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
