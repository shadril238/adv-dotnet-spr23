using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class CategoryRepo
    {
        static NewsContext db;
        static CategoryRepo()
        {
            db = new NewsContext();
        }

        public static List<Category> Get()
        {
            return db.Categories.ToList();
        }
        public static Category Get(int id)
        {
            return db.Categories.Find(id);
        }
        public static bool Create(Category category)
        {
            db.Categories.Add(category);
            return db.SaveChanges() > 0;
        }
        public static bool Update(Category category)
        {
            var exstCategory=db.Categories.Find(category.Id);
            db.Entry(exstCategory).CurrentValues.SetValues(category);
            return db.SaveChanges()>0;
        }
        public static bool Delete(int id)
        {
            var emp = Get(id);
            db.Categories.Remove(emp);
            return db.SaveChanges() > 0;
        }
    }
}
