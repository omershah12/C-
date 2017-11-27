using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcUserSQL.Models;

namespace MvcUserSQL.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Loggedin(String username, String password)
        {

            user person = new user();
            person.Name = "Omer";
            person.RegNo = 1;
            person.Marks = 900;

            if (username == "Omer" && password == "1234")
            {
                //ViewData["log"] = "You are logged in";
                return View("Loggedin", person);
            }
            else
            {
                ViewData["log"] = "You are NOT logged in";
                return View("Index");
            }
        }

    }
}