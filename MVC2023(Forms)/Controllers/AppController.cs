using Microsoft.AspNetCore.Mvc;
using MVC2023_Forms_.Models;

namespace MVC2023_Forms_.Controllers
{
    public class AppController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult HandleSubmit(UserProfile userProfile)
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            return RedirectToAction("ThankYou", userProfile);
        }
        public IActionResult ThankYou(UserProfile userProfile)
        {
            return View(userProfile);
        }
    }
}
