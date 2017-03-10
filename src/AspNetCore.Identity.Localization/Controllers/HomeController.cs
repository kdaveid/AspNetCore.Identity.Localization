using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace AspNetCore.Identity.Localization.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStringLocalizer<HomeController> _stringLocalizer;

        public HomeController(IStringLocalizer<HomeController> stringLocalizer)
        {
            _stringLocalizer = stringLocalizer;
        }

        public IActionResult Index()
        {
            ViewBag.MessageFromController = _stringLocalizer["This message comes from the controller."];
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
    }
}
