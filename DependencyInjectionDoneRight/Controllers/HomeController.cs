using System.Collections.Generic;
using System.Web.Mvc;
using DependencyInjectionDoneRight.Abstractions;

namespace DependencyInjectionDoneRight.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISorter _sorter;

        public HomeController(ISorter sorter)
        {
            _sorter = sorter;
        }      
        public ActionResult Index()
        {
            return View(new int[] { });
        }

        [HttpPost]
        public ActionResult Index(string numbers)
        {
            List<int> arrayOfNumbers = new List<int>();
            
            foreach(var numberAsString in numbers.Split(' '))
            {
                int number;
                if (int.TryParse(numberAsString, out number))
                    arrayOfNumbers.Add(number);
            }
            return View(_sorter.Sort(arrayOfNumbers.ToArray()));
        }
    }
}