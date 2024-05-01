using menu.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace menu.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            Console.WriteLine("I am in Home");
            _logger = logger;
        }

        public IActionResult Index()
        {
            Console.WriteLine("I am in Home");
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
