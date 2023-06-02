﻿using Microsoft.AspNetCore.Mvc;
using MVCWebApp2.Models;
using System.Diagnostics;

namespace MVCWebApp2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private RecordStoreContext _recordStoreContext;
        public HomeController(ILogger<HomeController> logger, RecordStoreContext newRecordStoreContext)

        {
            _recordStoreContext = newRecordStoreContext;
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

        public IActionResult DemoModel()
        {
            var newModel = new Models.DemoModel();
            var employeeNameList = new List<string>();
            foreach (var currUser in _recordStoreContext.Employee)
                employeeNameList.Add($"{currUser.FirstName} {currUser.LastName}");
            newModel.EmployeeNames = employeeNameList.ToArray(); 
            newModel.noCompanyRecords = _recordStoreContext.Company.Count(); 
            return View(newModel);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}