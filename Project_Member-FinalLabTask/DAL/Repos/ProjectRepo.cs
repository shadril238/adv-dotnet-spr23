using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class ProjectRepo : Repo, IRepo<Project, int, bool>
    {
        public bool Delete(int id)
        {
            var data = db.Projects.Find(id);
            if (data != null)
            {
                db.Projects.Remove(data);
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public List<Project> Get()
        {
            return db.Projects.ToList();
        }

        public Project Get(int id)
        {
            return db.Projects.Find(id);
        }

        public bool Insert(Project obj)
        {
            db.Projects.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(Project obj)
        {
            var exst=db.Projects.Find(obj.Id);
            if(exst != null)
            {
                db.Entry(exst).CurrentValues.SetValues(obj);
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
