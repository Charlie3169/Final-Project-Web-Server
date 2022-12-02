using Final_Project.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Final_Project.Controllers
{
    public class HobbieController : Controller
    {
        private readonly ILogger<HobbieController> _logger;

        public HobbieController(ILogger<HobbieController> logger)
        {
            _logger = logger;
        }
        public IActionResult Hobbie1()
        {
            return View();
        }

        public IActionResult Hobbie2()
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
