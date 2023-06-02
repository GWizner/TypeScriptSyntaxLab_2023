using API_with_Key_2023.Models;
using API_with_Key_2023.Models.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace API_with_Key_2023.Controllers
{
    public class HomeController : Controller
    {
        private readonly AnimalApiService _animalApiService;
        public HomeController(AnimalApiService animalApiService)
        {
            _animalApiService = animalApiService;
        }

        public async Task<IActionResult> Index()
        {
            try
            {
                List<AnimalResponse> result = await _animalApiService.GetAnimalBySearchTerm("shoebill");
                return View(result);
            }
            catch (Exception ex)
            {
                ViewBag.Exception = ex;
                Debug.WriteLine(ex);
                return View();
            }
        }
    }
}