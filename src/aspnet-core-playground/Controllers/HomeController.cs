using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using aspnet_core_playground.ViewModels.Manage;

namespace aspnet_core_playground.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
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
            return View();
        }

        [HttpPost]
        public IActionResult Phone(IndexViewModel indexViewModel)
        {
            if (!ModelState.IsValid)
            {
                return Index();
            }

            return RedirectToAction("About");
        }
    }
}
