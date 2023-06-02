using API_intro.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace API_intro.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            List<Post> posts = await ApiConnection.GetPosts();
            return View(posts.Take(5).ToList());
        }
    }
}