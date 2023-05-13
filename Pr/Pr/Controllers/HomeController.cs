using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pr.Models;
using Newtonsoft.Json;

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
        public IActionResult SavePersonJson()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SavePersonJson(Person person)
        {
            if (!ModelState.IsValid)
            { 
                return View(person);
            }
            var settings = new JsonSerializerSettings() { DateFormatString = "yyyy-MM-dd" };
            person.MiddleName = person.MiddleName ?? "";
            var json = JsonConvert.SerializeObject(person, Formatting.Indented, settings);
            System.IO.File.WriteAllText("PersonJson\\person.json", json);
            return RedirectToAction("SavePersonJson");
        }
        
    }
}
