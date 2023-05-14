using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pr.Models;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Linq;

namespace Pr.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult SavePersonJson()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SavePersonJson(Person person)
        {
            if (!ModelState.IsValid)
                return View(person);
            var settings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-dd" };
            var json = JsonConvert.SerializeObject(person, Formatting.Indented, settings);
            System.IO.File.WriteAllText("JsonData\\person.json", json);
            return RedirectToAction("SavePersonJson");
        }
        
    }
}
