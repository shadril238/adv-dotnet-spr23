//shadril238
using BLL.DTOs;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class CategoryService
    {
        public static List<CategoryDTO> Get()
        {
            var data=CategoryRepo.Get();
            return Convert(data);
        }
        public static CategoryDTO Get(int id)
        {
            return Convert(CategoryRepo.Get(id));
        }
        public static bool Create(CategoryDTO category)
        {
            var data=Convert(category);
            return CategoryRepo.Create(data);
        }
        public static bool Update(CategoryDTO category)
        {
            var data = Convert(category);
            return CategoryRepo.Update(data);
        }
        public static bool Delete(int id)
        {
            return CategoryRepo.Delete(id);
        }

        //Convertion between models and modelsDTO
        static CategoryDTO Convert(Category category)
        {
            return new CategoryDTO()
            {
                Id = category.Id,
                Name = category.Name,
            };
        }
        static Category Convert(CategoryDTO category)
        {
            return new Category()
            {
                Id = category.Id,
                Name = category.Name,
            };
        }
        static List<CategoryDTO> Convert(List<Category> categories)
        {
            var data = new List<CategoryDTO>();
            foreach (var category in categories)
            {
                data.Add(Convert(category));
            }
            return data;
        }
    }
}
