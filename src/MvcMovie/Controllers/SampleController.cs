using Microsoft.AspNetCore.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class SampleController : Controller
    {
        [HttpPost]
        public IActionResult Sort(SamplePostParameterViewModel parameter)
        {
            parameter = SampleHelper.Sort(parameter);

            return View(parameter);
        }

        [HttpPost]
        public IActionResult SortDescending(SamplePostParameterViewModel parameter)
        {
            parameter = SampleHelper.SortDescending(parameter);

            return View("Sort", parameter);
        }

        [HttpPost]
        public IActionResult Exist(SamplePostParameterViewModel parameter)
        {
            var existValue = SampleHelper.Exist(parameter);

            return View(existValue);
        }
    }
}