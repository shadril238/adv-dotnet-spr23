using EFIntro.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EFIntro.Controllers
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
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Student model)
        {
            //validation will be done later
            //insert operation
            var db = new dotnetEntities1();
            db.Students.Add(model);
            db.SaveChanges();
            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            var db = new dotnetEntities1();
            var students=db.Students.ToList();
            return View(students);
        }

        public ActionResult Details(int id)
        {
            var db = new dotnetEntities1();
            var st=(from s in db.Students where s.Id==id select s).SingleOrDefault();
            return View(st);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var db = new dotnetEntities1();
            var st = (from s in db.Students where s.Id == id select s).SingleOrDefault();
            return View(st);
        }
        [HttpPost]
        public ActionResult Edit(Student model)
        {
            var db = new dotnetEntities1();
            var exst = (from s in db.Students
                        where s.Id == model.Id
                        select s).SingleOrDefault();
            /*exst.Name = model.Name;
            exst.Profession = model.Profession;
            exst.Gender = model.Gender;
            exst.Dob = model.Dob;*/
            db.Entry(exst).CurrentValues.SetValues(model);
            //db.Students.Remove(exst);
            db.SaveChanges();
            return RedirectToAction("List");
        }
        public ActionResult Delete(int id)
        {
            var db = new dotnetEntities1();
            var st = (from s in db.Students where s.Id == id select s).SingleOrDefault();
            db.Students.Remove(st);
            db.SaveChanges();
            return RedirectToAction("List");
        }


    }
}