using Microsoft.AspNetCore.Mvc;
using MVCFormValidation_2023.Models;
using System.Diagnostics;

namespace MVCFormValidation_2023.Controllers
{
    public class HomeController : Controller
    {

        private readonly UserRepository _userRepository;

        public HomeController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Form(UserInfo userInfo)
        {
            if (ModelState.IsValid)
            {
                _userRepository.AddNewUser(userInfo);

                return View("Welcome", userInfo);
            }

            return View(userInfo);
        }

        public IActionResult SubmitUserDetails(UserInfo userInfo)
        {
            // Get saved user data from DB and display here. (We are using a mock DB for now.)

            UserInfo user = _userRepository.GetUserByEmail(userInfo.EmailAddress);

            if (user != null)
            {
                return View(user);
            }

            return RedirectToAction("Index");
        }

    }
}