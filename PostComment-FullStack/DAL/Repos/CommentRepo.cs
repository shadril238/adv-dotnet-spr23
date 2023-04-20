using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class CommentRepo : Repo, IRepo<Comment, int, bool>
    {
        public bool Create(Comment obj)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Comment> Read()
        {
            return db.Comments.ToList();
        }

        public Comment Read(int id)
        {
            return db.Comments.Find(id);
        }

        public bool Update(Comment obj)
        {
            throw new NotImplementedException();
        }
    }
}
