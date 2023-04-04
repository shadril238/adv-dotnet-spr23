using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class News
    {
        [Required, Key]
        public int Id { get; set; }
        [Required, StringLength(150)]
        public string Title { get; set; }
        [Required, StringLength(500)]
        public string Description { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required, ForeignKey("Category")]
        public int CId { get; set; }

        public virtual Category Category{ get; set; }

    }
}
