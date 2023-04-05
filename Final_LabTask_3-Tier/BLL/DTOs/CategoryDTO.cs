//shadril238
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class CategoryDTO
    {
        [Required]
        public int Id { get; set; }
        [Required, StringLength(50)]
        public string Name { get; set; }
        public virtual ICollection<NewsDTO> News { get; }
        public CategoryDTO()
        {
            News = new List<NewsDTO>();
        }
    }
}
