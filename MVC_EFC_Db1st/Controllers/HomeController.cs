using Microsoft.AspNetCore.Mvc;
using MVC_EFC_Db1st.Models;
using System.Diagnostics;

namespace MVC_EFC_Db1st.Controllers
{
    public class HomeController : Controller
    {
        private DessertDbContext _db;

        public HomeController(DessertDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return View(_db.Desserts.ToList());
        }

        
    }
}