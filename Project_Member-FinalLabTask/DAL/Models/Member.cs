using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Member
    {
        [Required, Key]
        public int Id { get; set; }
        [Required]
        public string Role { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        [Required, ForeignKey("Project")]
        public int MemId { get; set; }
        public virtual Project Project { get; set; }

    }
}
