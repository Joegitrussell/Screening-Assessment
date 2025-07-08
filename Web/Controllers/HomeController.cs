using Microsoft.AspNetCore.Mvc;
using Screening_Assessment.Controllers;
using Screening_Assessment.Models;
using System.Data;
using System.Diagnostics;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ViewableObjectModel _viewableObject = new ViewableObjectModel();

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            var count = ActionController.GetCounter();
            var dataObject = ActionController.GetReversedString();
            var statement = ActionController.GetStatement();

            _viewableObject.Count = count;
            _viewableObject.OriginalString = dataObject.OriginalString;
            _viewableObject.ReversedCharacters = dataObject.ReversedCharacters;
            _viewableObject.ReversedWords = dataObject.ReversedWords;
            _viewableObject.Statement = statement;

            return View(model: _viewableObject);
        }

        public IActionResult NumberOfClicks()
        {
            _viewableObject.Count = ActionController.GetCounter();

            return View(model: _viewableObject);
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
