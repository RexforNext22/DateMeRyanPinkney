using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using DateMeRyanPinkney.Models;

namespace DateMeRyanPinkney.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private DateApplicationContext blahContext { get; set; }

        public HomeController(ILogger<HomeController> logger, DateApplicationContext someName)
        {
            _logger = logger;
            blahContext = someName;
        }

        // Route for the index page
        public IActionResult Index()
        {
            return View();
        }

        // Route for the privacy page
        public IActionResult Privacy()
        {
            return View();
        }

        // Route for the application page
        [HttpGet]
        public IActionResult Application()
        {
            return View();
        }

        // Route for the application page POST
        [HttpPost]
        public IActionResult Application(Application response)
        {
            // Save the infomration to the database
            blahContext.Add(response);
            blahContext.SaveChanges();

            return View("com", response);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
