using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PMS_EFCodeFirst.EF.Models
{
    public class Category
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get;set; }
        public Category()
        {
            Products = new List<Product>();
        }

    }
}