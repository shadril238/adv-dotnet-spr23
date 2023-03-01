using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PMS_EFCodeFirst.EF.Models
{
    public class OrderDetail
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        [ForeignKey("Order")]
        public int OId { get; set; }
        [Required]
        [ForeignKey("Product")]
        public int PId { get; set; }
        [Required]
        public int Qty { get; set; }
        [Required]
        public double UnitPrice { get; set; }
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}