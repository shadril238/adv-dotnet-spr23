using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class MemberDTO
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Role { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        [Required]
        public int MemId { get; set; }
        public virtual Project Project { get; set; }
    }
}
