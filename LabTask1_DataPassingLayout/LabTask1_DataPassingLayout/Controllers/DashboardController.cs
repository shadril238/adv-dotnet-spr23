using LabTask1_DataPassingLayout.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LabTask1_DataPassingLayout.Controllers
{
    public class DashboardController : Controller
    {
        // GET: Dashboard
        public ActionResult Dashboard()
        {
            Student[] students = new Student[10];
           
            for (int i = 0; i < 10; i++)
            {
                Student student = new Student();
                student.Id = (i + 1);
                student.Name = "Student-" + (i + 1).ToString();
                student.Cgpa = 3.95;

            
                students[i] = student;
                
            }
            ViewBag.studentlist = students;
            return View();
        }

        public ActionResult Logout()
        {
            TempData["Msg"] = "Logged out successfully!";
            return RedirectToAction("Home","Pages");
        }
        
    }
}