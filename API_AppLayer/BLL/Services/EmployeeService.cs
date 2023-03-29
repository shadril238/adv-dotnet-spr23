//shadril238
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class EmployeeService
    {
        public static object Get()
        {
            return EmployeeRepo.GetEmp();
        }
        public static object Get(int id)
        {
            return EmployeeRepo.FindEmp(id);
        }
        public static bool Create(Employee employee)
        {
            return EmployeeRepo.CreateEmp(employee);
        }
        public static bool Update(Employee employee)
        {
            return EmployeeRepo.UpdateEmp(employee);
        }
        public static bool Delete(int id)
        {
            return EmployeeRepo.DeleteEmp(id);
        }
    }
}
