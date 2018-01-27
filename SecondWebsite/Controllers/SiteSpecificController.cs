using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SharedClassLibrary.Models;

namespace SecondWebsite.Controllers
{
    public class SiteSpecificController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
