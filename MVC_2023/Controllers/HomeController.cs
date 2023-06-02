using Microsoft.AspNetCore.Mvc;
using MVC_2023.Models;
using System.Diagnostics;

namespace MVC_2023.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MockDatabase _db;
        public HomeController(ILogger<HomeController> logger, MockDatabase mockDb)
        {
            _logger = logger;
            _db = mockDb;
        }

        public IActionResult Index()
        {
            return View(_db.GetUserProfiles());
        }
        public IActionResult Memes()
        {
            return View();
        }
        public IActionResult PassAnObject()
        {
            UserProfile objectToPass = new UserProfile();
            objectToPass.FirstName = "property1";
            objectToPass.LastName = "property2";
            objectToPass.Bio = "My bio";
            objectToPass.ProfileImage = "/Images/catdune.jpg";

            return View(objectToPass);
        }
        public IActionResult AboutMe()
        {
            List<string> info = new List<string>()
            {
                "Gregory",
                "40",
                "Gamer",
                "Student"
            };
            return View(info);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}