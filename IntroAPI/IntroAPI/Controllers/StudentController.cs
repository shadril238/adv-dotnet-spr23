using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IntroAPI.Controllers
{
    public class StudentController : ApiController
    {
        public List<string> GetStudents()
        {
            string[] names = new string[] { "Mery", "Shifat", "Gourob", "Prithy", "Rochi", "Apon" };
            return names.ToList();
        }

        public string Post()
        {
            return "Post Called";
        }
        public string Put()
        {
            return "Put Called";
        }
    }
}
