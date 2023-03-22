using PMS_EFCodeFirst.EF;
using PMS_EFCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS_EFCodeFirst.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(LoginModel login)
        {
            PMSContext db=new PMSContext();
            var user=(from u in db.Users
                     where u.Username.Equals(login.Username)
                     && u.Password.Equals(login.Password)
                     select u).SingleOrDefault();
            if (user != null)
            {
                Session["User"]=user;
                return RedirectToAction("Index", "Order");
            }
            TempData["Msg"] = "Invalid Username Password";
            return View(login);
        }

    }
}