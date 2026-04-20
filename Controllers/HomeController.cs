using KJO.PED.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace KJO.PED.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Organization()
        {
            return View();
        }

        public IActionResult Applications()
        {
            return View();
        }

        public IActionResult Documents()
        {
            return View();
        }

        public IActionResult News()
        {
            return View();
        }

        public IActionResult CompanyDirectory()
        {
            return View();
        }

        public IActionResult EmployeeAccess()
        {
            return View();
        }

        public IActionResult WeeklyHighlights()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel
            {
                RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier
            });
        }
    }
}