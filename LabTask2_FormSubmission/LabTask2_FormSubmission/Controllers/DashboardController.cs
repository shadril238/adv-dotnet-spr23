using LabTask2_FormSubmission.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabTask2_FormSubmission.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Dashboard() 
        { 
            List<Product> products = new List<Product>();
            for(int i = 1; i <= 10; i++)
            {
                products.Add(new Product()
                {
                    Pid= "pid-"+i,Pname="product-"+i
                });
            }


            return View(products);
        }
        public ActionResult Logout()
        {
            return RedirectToAction("Home","Pages");
        }
    }
}