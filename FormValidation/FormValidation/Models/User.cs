using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;

namespace FormValidation.Models
{
    public class User
    {
        [Required]
        [StringLength(40,ErrorMessage ="Custom error message")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Custom error message")]
        public string Id { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string Profession { get; set; }
        [Required]
        public string[] Hobbies { get; set; }
        [Required]
        public DateTime Dob { get; set; }

        public User()
        {
            Dob= DateTime.Now;
        }

    }
}