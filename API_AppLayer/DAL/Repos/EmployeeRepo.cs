using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class EmployeeRepo : Repo, IRepo<Employee, int, bool>
    {
        /*
        static empcontext db;
        static employeerepo()
        {
            db = new empcontext();
        }

        public static list<employee> getemp()
        {
            return db.employees.tolist();
        }

        public static employee findemp(int id)
        {
            return db.employees.find(id);
        }

        public static bool createemp(employee emp)
        {
            db.employees.add(emp);
            return db.savechanges()>0;
        }

        public static bool updateemp(employee emp)
        {
            var existemp=findemp(emp.id);
            db.entry(existemp).currentvalues.setvalues(emp);
            return db.savechanges() > 0;
        }

        public static bool deleteemp(int id)
        {
            var existemp = findemp(id);
            db.employees.remove(existemp);
            return db.savechanges() > 0;
        }
        */
        public bool Delete(int id)
        {
            var exst=db.Employees.Find(id);
            if (exst != null)
            {
                db.Employees.Remove(exst);
                return db.SaveChanges()>0;
            }
            return false;
        }

        public List<Employee> Get()
        {
            return db.Employees.ToList();
        }

        public Employee Get(int id)
        {
            return db.Employees.Find(id);
        }

        public bool Insert(Employee obj)
        {
            db.Employees.Add(obj);
            return db.SaveChanges()>0;
        }

        public bool Update(Employee obj)
        {
            var exst = db.Employees.Find(obj.Id);
            if (exst != null)
            {
                db.Entry(exst).CurrentValues.SetValues(obj);
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
