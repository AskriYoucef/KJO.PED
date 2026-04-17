using Microsoft.AspNetCore.Mvc;

namespace KJO.PED.Controllers
{
    public class DocumentsController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Documents";
            return View();
        }
    }
}
