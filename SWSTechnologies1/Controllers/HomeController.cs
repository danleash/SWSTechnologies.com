using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SWSTechnologies1.Models;
using Microsoft.EntityFrameworkCore;
using System.Web;
using Microsoft.Extensions.Configuration;
using static DataLibrary.Business_Logic.ContactClientProcessor;

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
        public ViewResult ContactClientForm()
        {
            ViewBag.Message = "How can we help you?";
            return View("ContactClientForm");
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult ContactClientForm(ContactClientModel model)
        {
            if (ModelState.IsValid)
            {
                int recordsCreated = CreateClient(model.Name, model.PhoneNumber, model.EmailAddress, model.Message);
                return RedirectToAction("Index");
            }
            return View();
        }
        
    }
}