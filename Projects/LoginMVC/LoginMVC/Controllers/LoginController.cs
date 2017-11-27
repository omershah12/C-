using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginMVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(String username, String password)
        {
            if(username=="Omer" && password == "1234")
            {
                //ViewData["log"] = "You are logged in";
                return View("Pass");
            }else
            {
                ViewData["log"] = "You are NOT logged in";
                return View("Fail");
            }
        }
    }
}