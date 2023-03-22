using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PMS_EFCodeFirst.EF.Models
{
    public class User
    {
        [Key]
        [StringLength(10)]
        public string Username { get; set; }
        [Required]
        [StringLength(20)]
        public string Password { get; set; }
        [Required]
        [StringLength(10)]
        public string Type { get; set; }

        public virtual ICollection<Order> Orders { get; set; }

        public User()
        {
            Orders= new List<Order>();
        }
    }
}