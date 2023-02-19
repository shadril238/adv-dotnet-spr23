using LabTask_DB.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabTask_DB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult AddProduct()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddProduct(Product model)
        {
            var db = new LabTask_DBEntities();
            db.Products.Add(model);
            db.SaveChanges();
            return RedirectToAction("List");
        }
        [HttpGet]
        public ActionResult List()
        {
            var db = new LabTask_DBEntities();
            var products = db.Products.ToList();
            return View(products);
        }

        public ActionResult Details(int id)
        {
            var db = new LabTask_DBEntities();
            var product = (from p in db.Products where p.Id == id select p).SingleOrDefault();
            return View(product);
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var db = new LabTask_DBEntities();
            var product = (from p in db.Products where p.Id == id select p).SingleOrDefault();
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product model)
        {
            var db = new LabTask_DBEntities();
            var exst = (from p in db.Products where p.Id == model.Id select p).SingleOrDefault();
            db.Entry(exst).CurrentValues.SetValues(model);
            db.SaveChanges();
            return RedirectToAction("List");
        }

        public ActionResult Delete(int id)
        {
            var db = new LabTask_DBEntities();
            var st = (from p in db.Products where p.Id == id select p).SingleOrDefault();
            db.Products.Remove(st);
            db.SaveChanges();
            return RedirectToAction("List");
        }
    }   
}