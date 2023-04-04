using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Category
    {
        [Required, Key]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        public virtual ICollection<News> News { get;}
        public Category()
        {
            News = new List<News>();
        }
    }
}
