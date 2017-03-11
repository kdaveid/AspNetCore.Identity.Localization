using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using AspNetCore.Identity.Localization.Models;
using AspNetCore.Identity.Localization.Models.AccountViewModels;
using AspNetCore.Identity.Localization.Services;
using Microsoft.Extensions.Localization;

namespace AspNetCore.Identity.Localization.Admin.Controllers
{
    [Area("admin")]
    public class HomeController : Controller
    {
        private readonly IStringLocalizer<HomeController> _stringLocalizer;

        public HomeController(IStringLocalizer<HomeController> stringLocalizer)
        {
            _stringLocalizer = stringLocalizer;
        }

        public IActionResult Index()
        {
            ViewBag.Message = _stringLocalizer["admin-message"];
            return View();
        }
    }
}