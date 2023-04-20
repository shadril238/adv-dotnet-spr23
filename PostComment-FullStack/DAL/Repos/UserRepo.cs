using DAL.Interfaces;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class UserRepo : Repo, IRepo<User, string, User>, IAuth<bool>
    {
        public bool Authenticate(string username, string password)
        {
            var data=db.Users.FirstOrDefault(u=>u.Uname.Equals(username) && u.Password.Equals(password));
            if(data!=null) return true;
            return false;
        }

        public User Create(User obj)
        {
            db.Users.Add(obj);
            if(db.SaveChanges()>0)return obj;
            return null;
        }

        public bool Delete(string id)
        {
            var exst = db.Users.Find(id);
            db.Users.Remove(exst);
            return db.SaveChanges() > 0;
        }

        public List<User> Read()
        {
            return db.Users.ToList();
        }

        public User Read(string id)
        {
            return db.Users.Find(id);
        }

        public User Update(User obj)
        {
            var exst = db.Users.Find(obj.Uname);
            db.Entry(exst).CurrentValues.SetValues(obj);
            if(db.SaveChanges() > 0)return obj;
            return null;
        }
    }
}
