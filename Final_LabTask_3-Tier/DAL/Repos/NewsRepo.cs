using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class NewsRepo : Repo, IRepo<News, int, bool>
    {
        /*
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
        */
        public bool Delete(int id)
        {
            var data=db.News.Find(id);
            if (data != null)
            {
                db.News.Remove(data);
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public List<News> Get()
        {
            return db.News.ToList();
        }

        public News Get(int id)
        {
            return db.News.Find(id);
        }

        public bool Insert(News obj)
        {
            db.News.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(News obj)
        {
            var exst = db.News.Find(obj.Id);
            if (exst != null)
            {
                db.Entry(exst).CurrentValues.SetValues(obj);
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
