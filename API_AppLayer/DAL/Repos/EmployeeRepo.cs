using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class EmployeeRepo
    {
        static EmpContext db;
        static EmployeeRepo()
        {
            db = new EmpContext();
        }

        public static List<Employee> GetEmp()
        {
            return db.Employees.ToList();
        }

        public static Employee FindEmp(int id)
        {
            return db.Employees.Find(id);
        }

        public static bool CreateEmp(Employee emp)
        {
            db.Employees.Add(emp);
            return db.SaveChanges()>0;
        }

        public static bool UpdateEmp(Employee emp)
        {
            var existEmp=FindEmp(emp.Id);
            db.Entry(existEmp).CurrentValues.SetValues(emp);
            return db.SaveChanges() > 0;
        }

        public static bool DeleteEmp(int id)
        {
            var existEmp = FindEmp(id);
            db.Employees.Remove(existEmp);
            return db.SaveChanges() > 0;
        }
    }
}
