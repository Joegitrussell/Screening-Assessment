using Microsoft.AspNetCore.Mvc;
using Screening_Assessment.Models;
using Web.Models;

namespace Screening_Assessment.Controllers
{
    public class ActionController : Controller
    {
        private static ViewableObjectModel _viewModel = new ViewableObjectModel();
        private static int _counter = 0;

        [HttpPost]
        public IActionResult Increment()
        {
            _counter++;
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult ReverseString(string input)
        {
         
            if (!string.IsNullOrWhiteSpace(input))
            {
                _viewModel.OriginalString = input;
                _viewModel.ReversedCharacters = new string(input.Reverse().ToArray());
                _viewModel.ReversedWords = string.Join(" ",
                    input.Split(' ', System.StringSplitOptions.RemoveEmptyEntries).Reverse());
            }

            return RedirectToAction("Index", "Home");
        }

        public static int GetCounter()
        {
            return _counter;
        }

        public static ViewableObjectModel GetReversedString()
        {
            return _viewModel;
        }
    }
}