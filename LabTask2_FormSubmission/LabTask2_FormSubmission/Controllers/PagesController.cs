using LabTask2_FormSubmission.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabTask2_FormSubmission.Controllers
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
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(Login login)
        {
            
            return View(login);
        }
    }
}