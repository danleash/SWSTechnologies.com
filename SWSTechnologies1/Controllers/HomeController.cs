using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SWSTechnologies1.Models;

namespace SWSTechnologies.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("HomePage");
        }
        public ViewResult ContactUs()
        {
            return View("ContactUs");
        }
        public ViewResult About()
        {
            return View("About");
        }
        public ViewResult Testimonials()
        {
            return View("Testimonials");
        }

    }
}