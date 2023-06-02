using Jul25_22.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Jul25_22.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private TestContext _testContext;
        private readonly IHttpClientFactory clientFactory;
        public HomeController(ILogger<HomeController> logger, TestContext newTestContext, IHttpClientFactory newClientFactory)
        {
            _logger = logger;
            _testContext = newTestContext;
            clientFactory = newClientFactory;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult DisplayProducts()
        {
            var productList = _testContext.Products.ToArray();
            return View(productList);
        }
        public IActionResult ProductDetails(int id)
        {
            Products foundProduct = null;
            foreach (var currProduct in _testContext.Products.ToArray())
            {
                if (currProduct.ID == id)
                {
                    foundProduct = currProduct;
                    break;
                }
            }
            return View(foundProduct);
        }
        public IActionResult CreateNewProduct()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateNewProductSubmit(Products newProduct)
        {
            _testContext.Products.Add(newProduct);
            _testContext.SaveChanges();
            return View("ProductDetails", newProduct);

        }
        public IActionResult ShowCurrentTime()
        {
            string apiUrl = "http://worldtimeapi.org/api/timezone/America/Detroit";
            var apiClient = clientFactory.CreateClient();
            var apiResult = apiClient.GetFromJsonAsync<CurrentTimeResponse>(apiUrl).GetAwaiter().GetResult();
            //var apiResult = apiClient.PostAsJsonAsync<CurrentTimeResponse>(apiUrl, null).GetAwaiter().GetResult();
            return View(apiResult);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
    public class CurrentTimeResponse
    {
        public string abbreviation { get; set; }
        public string client_ip { get; set; }
        public DateTime dateTime { get; set; }
        public int day_of_week { get; set; }
        public int day_of_year { get; set; }
        public bool dst { get; set; }
        public DateTime dst_from { get; set; }
        public int dst_offset { get; set; }
    }
}