using API_CRUD.EF.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace API_CRUD.EF
{
    public class EmpContext:DbContext
    {
        public DbSet<Employee> Employees { get; set; }
    }
}