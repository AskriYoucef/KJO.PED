using Microsoft.AspNetCore.Mvc;

namespace KJO.PED.Controllers
{
    public class PoliciesController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Policies & Procedures";
            return View();
        }
    }
}
