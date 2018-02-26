using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bootstrap_Lab_module_5.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Advanced()
        {
            var person = new bootstrap_Lab_module_5.Models.Person
            {
                FirstName = "Ryan",
                LastName = "Kolmeister"
            };
            return View(person);
        }
    }
}