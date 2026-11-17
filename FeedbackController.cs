using Microsoft.AspNetCore.Mvc;
using Practical_7.Models;

namespace Practical_7.Controllers
{
    public class FeedbackController : Controller
    {
        // GET: Feedback
        public IActionResult Index()
        {
            return View();
        }

        // POST: Feedback
        [HttpPost]
        public IActionResult Index(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                TempData["Message"] = "Feedback submitted successfully!";
                return RedirectToAction("Index");
            }

            return View(feedback);
        }
    }
}