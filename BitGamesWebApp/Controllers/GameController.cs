using Microsoft.AspNetCore.Mvc;

namespace BitGamesWebApp.Controllers
{
    public class GameController : Controller
    {
        public IActionResult GameList()
        {
            return View();
        }
    }
}
