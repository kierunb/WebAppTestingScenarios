using Microsoft.AspNetCore.Mvc;
using SimpleWebApplication.Models;
using System.Diagnostics;

namespace SimpleWebApplication.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult WithModel()
        {
            return View(new SimpleViewModel());
        }

        public IActionResult DataModel()
        {
            return Ok(new SimpleDataModel { Id = 1, Name = "Data model 1" });
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext?.TraceIdentifier });
        }
    }

}