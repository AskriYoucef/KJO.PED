using KJO.PED.Models;
using Microsoft.AspNetCore.Mvc;

namespace KJO.PED.Controllers
{
    public class WeeklyHighlightsController : Controller
    {
        // In-memory sample store. Replace with DB later.
        private static readonly List<WeeklyHighlight> _store = new();
        private static int _nextId = 1;

        public IActionResult Index()
        {
            ViewData["Title"] = "Weekly Highlights";
            var items = _store.OrderByDescending(x => x.SubmittedAt).ToList();
            return View(items);
        }

        public IActionResult Submit()
        {
            ViewData["Title"] = "Submit Highlight";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Submit(WeeklyHighlight model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            model.Id = _nextId++;
            model.SubmittedAt = DateTime.UtcNow;
            model.SubmittedBy ??= "anonymous";
            _store.Add(model);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Review()
        {
            ViewData["Title"] = "Review Highlights";
            var pending = _store.Where(x => !x.IsApproved).OrderBy(x => x.SubmittedAt).ToList();
            return View(pending);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Approve(int id)
        {
            var item = _store.FirstOrDefault(x => x.Id == id);
            if (item == null) return NotFound();

            item.IsApproved = true;
            item.ReviewedAt = DateTime.UtcNow;
            item.ReviewedBy = "reviewer";

            return RedirectToAction(nameof(Review));
        }

        public IActionResult ApproveView(int id)
        {
            var item = _store.FirstOrDefault(x => x.Id == id);
            if (item == null) return NotFound();
            return View(item);
        }
    }
}
