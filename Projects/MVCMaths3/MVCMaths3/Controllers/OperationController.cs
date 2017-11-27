using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCMaths3.Controllers
{
    public class OperationController : Controller
    {
        // GET: Operation
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Operation(int No1, int No2, String operation)
        {
            int result = 0;
            ViewData["No1"] = No1;
            ViewData["No2"] = No2;


            if (operation == "add")
            {
                result = No1 + No2;
                ViewData["NewOp"] = "Addition";
                ViewData["Result"] = result;
                return View("Output");
            }else if(operation=="sub")
            {
                result = No1 - No2;
                ViewData["NewOp"] = "Subtraction";
                ViewData["Result"] = result;
                return View("Output");
            }
            else if (operation == "mul")
            {
                result = No1 * No2;
                ViewData["NewOp"] = "Multiplication";
                ViewData["Result"] = result;
                return View("Output");
            }
            else if (operation == "div")
            {
                result = No1 / No2;
                ViewData["NewOp"] = "Division";
                ViewData["Result"] = result;
                return View("Output");
            }else
            {
                ViewData["No1"] = No1;
                ViewData["No2"] = No2;
                return View("Output");
            }
        }
    }
}