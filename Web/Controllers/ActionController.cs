using Microsoft.AspNetCore.Mvc;
using Screening_Assessment.Models;
using System;
using System.Numerics;
using System.Reflection.Metadata;
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

        public static string GetStatement()
        {
            var statement = "I found the assignment interesting and enjoyable, it's been a while since I have played with MVC architecture, it was fun to blow of the cobwebs." +
                " I Spent around two hours of actual work on it, and then with time spent learning how to do stuff etc. Good tech test i would say.";

            return statement;
        }
    }
}