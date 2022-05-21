using Microsoft.AspNetCore.Mvc;
using Save__Your__Apps.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Authorization;

namespace Save__Your__Apps.Controllers
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
        [Authorize]
        [ValidateAntiForgeryToken]
        public IActionResult Apps()
        {
            return View();
        }
        [Authorize]
        [ValidateAntiForgeryToken]
        public IActionResult AppDetailedStatistics()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        //public IActionResult Privacy()
        //{
        //    return View();
        //}

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}