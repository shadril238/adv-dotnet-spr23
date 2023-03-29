﻿//shadril238
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Employee
    {
        [Required,Key]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
    }
}
