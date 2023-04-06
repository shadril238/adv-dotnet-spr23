using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<News, int, bool> NewsData()
        {
            return new NewsRepo();
        }

        public static IRepo<Category, int, bool> CategorysData()
        {
            return new CategoryRepo();
        }
    }
}
