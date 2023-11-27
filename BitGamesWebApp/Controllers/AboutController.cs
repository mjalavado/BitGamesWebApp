using Microsoft.AspNetCore.Mvc;

namespace BitGamesWebApp.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult AboutUs()
        {
            return View();
        }
    }
}
