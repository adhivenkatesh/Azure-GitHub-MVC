using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcGitHub.Abstraction;
using MvcGitHub.FactoryClasses;
using MvcGitHub.Models;

namespace MvcGitHub.Controllers
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
            NotificationCreator notificationCreator = new Bank_HDFC();
            ViewBag.data=notificationCreator.Notify(notificationCreator.GetType().Name.ToUpper());

            return View();
        }

        public IActionResult HDFC()
        {
            NotificationCreator notificationCreator = new Bank_HDFC();
            ViewBag.data = notificationCreator.Notify(notificationCreator.GetType().Name.ToUpper());


            return View();
        }

        public IActionResult SBI()
        {
            NotificationCreator notificationCreator = new Bank_SBI();
            ViewBag.data = notificationCreator.Notify(notificationCreator.GetType().Name.ToUpper());


            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
