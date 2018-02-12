using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVCwebApp.Controllers
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
        public ActionResult CalcApp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CalcApp(string valA, string valb, string op)
        {
            var total = 0;
            var results = "";
            
                var numOne = Request["value1"];
                var numTwo = Request["value2"];
                var mod = Request.Form["modifier"];

                int numberOne = Convert.ToInt32(numOne);
                int numberTwo = Convert.ToInt32(numTwo);

                if ((numberOne | numberTwo) == null)
                {
                    results = "ERROR there are no numbers!";
                }
                else if (mod == "add")
                {
                    total = numberOne + numberTwo;
                }
                else if (mod == "subtract")
                {
                    total = numberOne - numberTwo;
                }
                else if (mod == "multiply")
                {
                    total = numberOne * numberTwo;
                }
                else if (mod == "divide")
                {
                    total = numberOne / numberTwo;
                }
                results = Convert.ToString(total);
            
            return View("CalcApp", (object)results);
        }
    }
}