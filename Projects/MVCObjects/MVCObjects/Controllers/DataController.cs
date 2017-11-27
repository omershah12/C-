using MVCObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCObjects.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        public ActionResult Index()
        {
            return View("View");
        }

        public ActionResult Process(Info x)
        {
            if( x.M > 57 && x.M <= 59){
                x.M = 60;
            }
            ViewData["Name"] = x.N;
            ViewData["Address"] = x.A;
            ViewData["Marks"] = x.M;
            return View("View1", x);
        }
    }
}