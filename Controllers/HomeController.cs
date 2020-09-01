using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_11._2_Coffee_Shop_Registration.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Register for Coffee";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Ask Questions about Registering for Coffee!";

            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult AddUser(string firstName, string state)
        {
            ViewBag.Welcome = $"Hello, {firstName} from {state}!";
            return View();
        }
    }
}