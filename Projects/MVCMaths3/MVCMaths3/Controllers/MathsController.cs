using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMaths3.Controllers
{
    public class MathsController : Controller
    {
        // GET: Maths
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Add() {
            ViewData["opt"] = "add";
            return View("InputForm");
        }

        public ActionResult Sub()
        {
            ViewData["opt"] = "sub";
            return View("InputForm");
        }

        public ActionResult Mul()
        {
            ViewData["opt"] = "mul";
            return View("InputForm");
        }

        public ActionResult Div()
        {
            ViewData["opt"] = "div";
            return View("InputForm");
        }
    }
}