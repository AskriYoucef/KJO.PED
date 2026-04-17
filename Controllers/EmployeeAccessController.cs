using Microsoft.AspNetCore.Mvc;

namespace KJO.PED.Controllers
{
    public class EmployeeAccessController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Employee Access";
            return View();
        }
    }
}
