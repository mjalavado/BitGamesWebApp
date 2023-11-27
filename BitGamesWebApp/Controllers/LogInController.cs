using Microsoft.AspNetCore.Mvc;

namespace BitGamesWebApp.Controllers
{
    public class LogInController : Controller
    {
        public IActionResult SignIn()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
