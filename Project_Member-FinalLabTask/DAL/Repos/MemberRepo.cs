using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class MemberRepo : Repo, IRepo<Member, int, bool>
    {
        public bool Delete(int id)
        {
            var data = db.Members.Find(id);
            if (data != null)
            {
                db.Members.Remove(data);
                return db.SaveChanges() > 0;
            }
            return false;
        }

        public List<Member> Get()
        {
            return db.Members.ToList();
        }

        public Member Get(int id)
        {
            return db.Members.Find(id);
        }

        public bool Insert(Member obj)
        {
            db.Members.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Update(Member obj)
        {
            var exst = db.Members.Find(obj.Id);
            if (exst != null)
            {
                db.Entry(exst).CurrentValues.SetValues(obj);
                return db.SaveChanges() > 0;
            }
            return false;
        }
    }
}
