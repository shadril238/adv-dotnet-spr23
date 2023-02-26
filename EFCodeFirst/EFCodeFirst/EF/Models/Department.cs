using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EFCodeFirst.EF.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public Department()
        {
            Students = new List<Student>();
        }
    }
}