using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataPassingLayout.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Index()
        {
            ViewBag.Title = "Index";
            return View();
        }

        public ActionResult MyProfile()
        {
            ViewBag.Title = "Profile";
            ViewBag.Name = "Shadril Hassan Shifat";
            ViewBag.Course = "Adv. dotNet";
            ViewBag.Section = "A";
            ViewBag.Groupmates = new string[] { "Rifat", "Himel", "Kaissa" };
            return View();
        }

        public ActionResult Settings()
        {
            ViewBag.Title = "Settings";
            return View();
        }
        public ActionResult Logout()
        {
            return View();
        }
    }
}