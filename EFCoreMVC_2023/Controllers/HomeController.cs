using EFCoreMVC_2023.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EFCoreMVC_2023.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppUserRepository _appUserRepo;
        //This could be an interface, allowing to create a db vs. a test/mock db

        public HomeController(AppUserRepository appUserRepository)
        {
           _appUserRepo = appUserRepository;
        }

        public IActionResult Index()
        {
            List<AppUser> appUsers = _appUserRepo.GetAppUsers();
            return View(appUsers);
            //return View(_appUserRepo.GetAppUsers());
        }
        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Form(AppUser appUser)
        {
            _appUserRepo.AddSingleUser(appUser);

            return RedirectToAction("Index");
        }

    }
}