using Microsoft.AspNetCore.Mvc;
using Screening_Assessment.Controllers;
using System.Diagnostics;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index(int? count)
        {
            int currentCount = count ?? CounterController.GetCounter();
            return View(model: currentCount);
        }

        public IActionResult NumberOfClicks(int? count)
        {
            int currentCount = count ?? CounterController.GetCounter();
            return View(model: currentCount);
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
