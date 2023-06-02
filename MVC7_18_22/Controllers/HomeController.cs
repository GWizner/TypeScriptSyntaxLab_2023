using Microsoft.AspNetCore.Mvc;
using MVC7_18_22.Models;
using System.Diagnostics;

namespace MVC7_18_22.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private RecordStoreContext _recordStoreContext;


        public HomeController(ILogger<HomeController> logger, RecordStoreContext newRecordStoreContext)
        {
            _logger = logger;
            _recordStoreContext = newRecordStoreContext;
        }


        public IActionResult Index()
        {
            {
                return View();
            }

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