using Microsoft.AspNetCore.Mvc;

namespace Screening_Assessment.Controllers
{
    public class CounterController : Controller
    {
        private static int _counter = 0;

        [HttpPost]
        public IActionResult Increment()
        {
            _counter++;
            return RedirectToAction("Index", "Home", new { count = _counter });
        }

        public static int GetCounter()
        {
            return _counter;
        }
    }
}
