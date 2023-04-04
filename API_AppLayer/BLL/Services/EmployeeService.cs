//shadril238
using BLL.DTOs;
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
        public static List<EmployeeDTO> Get()
        {
            var data = EmployeeRepo.GetEmp();
            return Convert(data.ToList());
        }
        public static EmployeeDTO Get(int id)
        {
            return Convert(EmployeeRepo.FindEmp(id));
        }
        public static bool Create(EmployeeDTO employee)
        {
            var data = Convert(employee);
            return EmployeeRepo.CreateEmp(data);
        }
        public static bool Update(EmployeeDTO employee)
        {
            var data = Convert(employee);
            return EmployeeRepo.UpdateEmp(data);
        }
        public static bool Delete(int id)
        {
            return EmployeeRepo.DeleteEmp(id);
        }

        //Convertion Methods
        static EmployeeDTO Convert(Employee employee)
        {
            return new EmployeeDTO()
            {
                Id = employee.Id,
                Name = employee.Name,
            };
        }

        static Employee Convert(EmployeeDTO employee)
        {
            return new Employee()
            {
                Id = employee.Id,
                Name = employee.Name,
            };
        }

        static List<EmployeeDTO> Convert(List<Employee> employees)
        {
            var data=new List<EmployeeDTO>();
            foreach (var employee in employees)
            {
                data.Add(Convert(employee));
            }
            return data;
        }


    }
}
