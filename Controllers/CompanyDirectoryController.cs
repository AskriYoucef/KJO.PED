using System.Linq;
using Microsoft.AspNetCore.Mvc;
using KJO.PED.Data;
using KJO.PED.ViewModels;

namespace KJO.PED.Controllers
{
    public class CompanyDirectoryController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            var employees = CompanyDirectoryDemoData.GetEmployees()
                .OrderBy(x => x.Section)
                .ThenBy(x => x.LastName)
                .ThenBy(x => x.FirstName)
                .ToList();

            var model = new CompanyDirectoryViewModel
            {
                AvailableSections = employees
                    .Select(x => x.Section)
                    .Distinct()
                    .OrderBy(x => x)
                    .ToList(),
                Employees = employees
            };

            ViewData["Title"] = "Company Directory";
            return View(model);
        }
    }
}
