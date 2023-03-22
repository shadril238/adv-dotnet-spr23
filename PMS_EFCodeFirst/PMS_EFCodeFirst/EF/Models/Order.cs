using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PMS_EFCodeFirst.EF.Models
{
    public class Order
    {
        [Required]
        [Key]
        public int Id { get; set; }
        [Required]
        public double Total { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public string Status { get; set; }
        [ForeignKey("OrderedByUser")]
        public string OrderedBy { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual User OrderedByUser { get; set; }
        public Order()
        {
            OrderDetails = new List<OrderDetail>();
        }
    }
}