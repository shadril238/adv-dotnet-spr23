using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataPassingLayout.Controllers
{
    public class PagesController : Controller
    {
        // GET: Pages
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Signup() 
        { 
            return View();
        }
        public ActionResult SignupSubmit()
        {
            return Redirect("https://portal.aiub.edu");
        }
        public ActionResult LoginSubmit()
        {
            TempData["Msg"] = "Login Successful";
            return RedirectToAction("Index","Dashboard");
        }

    }
}