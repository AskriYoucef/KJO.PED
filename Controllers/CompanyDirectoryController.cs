using Microsoft.AspNetCore.Mvc;

namespace KJO.PED.Controllers
{
    public class CompanyDirectoryController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Company Directory";
            return View();
        }
    }
}
