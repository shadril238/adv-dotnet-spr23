using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LabTask1_DataPassingLayout.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Cgpa { get; set; }

        public Student() 
        { 
            //empty cons.
        }
    }
}