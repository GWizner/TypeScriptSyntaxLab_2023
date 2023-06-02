using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCkata2.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MVCkata2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult EditUser(int Id)
        {
            User targetUser = null;

            foreach (var currUser in Program.userList)
            {
                if (currUser.Id == Id)
                {
                    targetUser = currUser;
                    break;
                }
            }

            if (targetUser != null)
            {
                return View("EditUser", targetUser);
            }
            else
            {
                return View("ErrorNoUser");
            }
        }

        public IActionResult EditUserSubmit(User newUserData)
        {
            User targetUser = null;

            foreach (var currUser in Program.userList)
            {
                if (currUser.Id == newUserData.Id)
                {
                    targetUser = currUser;
                    break;
                }
            }

            if (targetUser != null)
            {
                targetUser.FirstName = newUserData.FirstName;
                targetUser.LastName = newUserData.LastName;
                targetUser.FavoriteCartoon = newUserData.FavoriteCartoon;
                return Redirect("/");
            }
            else
            {
                return View("ErrorNoUser");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
