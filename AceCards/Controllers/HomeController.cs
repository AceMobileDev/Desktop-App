using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AceCards.Models;
using System.Net;
using System.Timers;

using AceCards.Domain.Models;
using AceCards.Infrastructure.Abstract;

namespace AceCards.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITestService _testService;

        public HomeController(ITestService testService)
        {
            _testService = testService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            IEnumerable<TestModel> users;
            users = _testService.GetRegisteredUsers();

            foreach (var x in users)
            {
                ViewBag.REPO = x.Id + x.Name + x.isActive;
            }
           
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
