using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class NewsRepo
    {
        static NewsContext db;
        static NewsRepo()
        {
            db = new NewsContext();
        }

        public static List<News> Get()
        {
            return db.News.ToList();
        }
        public static News Get(int id)
        {
            return db.News.Find(id);
        }
        public static bool Create(News news)
        {
            db.News.Add(news);
            return db.SaveChanges()>0;
        }
        public static bool Update(News news)
        {
            var exstNews = Get(news.Id);
            db.Entry(exstNews).CurrentValues.SetValues(news);
            return db.SaveChanges()>0;
        }
        public static bool Delete(int id)
        {
            var news = Get(id);
            db.News.Remove(news);
            return db.SaveChanges() > 0;
        }
    }
}
