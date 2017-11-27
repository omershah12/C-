using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMaths.Controllers
{
    public class MathController : Controller
    {
        // GET: Math
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add(int a, int b)
        {
            int c = a + b;
            ViewData["No1"] = a;
            ViewData["No2"] = b;
            ViewData["No3"] = c;

            if(c > 50)
            {
                ViewData["Result"] = "You pass";
            }else
            {
                ViewData["Result"] = "You fail";
            }

            return View("Addition");
        }
        public ActionResult Multiply(int a, int b)
        {
            int c = a * b;
            ViewData["No1"] = a;
            ViewData["No2"] = b;
            ViewData["No3"] = c;

            if (c > 50)
            {
                ViewData["Result"] = "You pass";
            }
            else
            {
                ViewData["Result"] = "You fail";
            }
            return View("Multiply");
        }
        public ActionResult Subtract(int a, int b)
        {
            int c = a - b;
            ViewData["No1"] = a;
            ViewData["No2"] = b;
            ViewData["No3"] = c;

            if (c > 50)
            {
                ViewData["Result"] = "You pass";
            }
            else
            {
                ViewData["Result"] = "You fail";
            }
            return View("Subtract");
        }

        public ActionResult Division(int a, int b)
        {
            int c = a / b;
            ViewData["No1"] = a;
            ViewData["No2"] = b;
            ViewData["No3"] = c;

            if (c > 50)
            {
                ViewData["Result"] = "You pass";
            }
            else
            {
                ViewData["Result"] = "You fail";
            }
            return View("Division");
        }

        public ActionResult Calculation(int no1, int no2)
        {
            int c = no1 + no2;
            ViewData["Result"] = c;

            return View();
        }
    }
}