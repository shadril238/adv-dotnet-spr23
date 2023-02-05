using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabTask1_DataPassingLayout.Controllers
{
    public class PagesController : Controller
    {
        // GET: Pages
        public ActionResult Home()
        {
            return View();
        }

        public ActionResult Aboutus()
        {
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult LoginSubmit()
        {
            TempData["Msg"] = "Logged in successfully!";
            return RedirectToAction("Dashboard","Dashboard");
        }
    }
}