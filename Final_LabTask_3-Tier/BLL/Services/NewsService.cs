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
    public class NewsService
    {

        public static List<NewsDTO> Get()
        {
            var data = NewsRepo.Get();
            return Convert(data);
        }

        public static NewsDTO Get(int id)
        {
            return Convert(NewsRepo.Get(id));
        }
        public static bool Create(NewsDTO news)
        {
            var data = Convert(news);
            return NewsRepo.Create(data);
        }
        public static bool Update(NewsDTO news)
        {
            var data = Convert(news);
            return NewsRepo.Update(data);
        }
        public static bool Delete(int id)
        {
            return NewsRepo.Delete(id);
        }

        //Convertion between models and modelsDTO
        static NewsDTO Convert(News News)
        {
            return new NewsDTO()
            {
                Id=News.Id,
                Title=News.Title,
                Description=News.Description,
                Date=News.Date,
                CId=News.CId
            };
        }
        static News Convert(NewsDTO News)
        {
            return new News()
            {
                Id = News.Id,
                Title = News.Title,
                Description = News.Description,
                Date = News.Date,
                CId = News.CId
            };
        }
        static List<NewsDTO> Convert(List<News> News)
        {
            var data=new List<NewsDTO>();
            foreach (var news in News)
            {
                data.Add(Convert(news));
            }
            return data;
        }
    }
}
