using BitGamesWebApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BitGamesWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}