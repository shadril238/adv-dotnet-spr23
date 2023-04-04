//shadril238
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class NewsDTO
    {
        [Required]
        public int Id { get; set; }
        [Required, StringLength(150)]
        public string Title { get; set; }
        [Required, StringLength(500)]
        public string Description { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public int CId { get; set; }
    }
}
