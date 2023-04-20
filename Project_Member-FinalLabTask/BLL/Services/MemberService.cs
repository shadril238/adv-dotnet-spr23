using BLL.DTOs;
using DAL;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class MemberService
    {
        //Convertion Methods
        static MemberDTO Convert(Member member)
        {
            return new MemberDTO()
            {
                Id = member.Id,
                Name = member.Name,
                Role = member.Role
            };
        }

        static Member Convert(MemberDTO member)
        {
            return new Member()
            {
                Id = member.Id,
                Name = member.Name,
                Role = member.Role
            };
        }

        static List<MemberDTO> Convert(List<Member> Members)
        {
            var data=new List<MemberDTO>();
            foreach (var member in Members)
            {
                data.Add(Convert(member));
            }
            return data;
        }

        //CRUD
        public static List<MemberDTO> Get()
        {
            var data = DataAccessFactory.MemberData().Get();
            return Convert(data);
        }

        public static MemberDTO Get(int id)
        {
            var data= DataAccessFactory.MemberData().Get(id);   
            return Convert(data);
        }
        
        public static bool Insert(MemberDTO member)
        {
            var data=Convert(member);
            return DataAccessFactory.MemberData().Insert(data);
        }
        public static bool Update(MemberDTO member)
        {
            var data=Convert(member);
            return DataAccessFactory.MemberData().Update(data);

        }
        public static bool Delete(int id)
        {
            return DataAccessFactory.MemberData().Delete(id);
        }
    }
}
