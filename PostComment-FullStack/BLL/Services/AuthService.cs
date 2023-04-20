using AutoMapper;
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
    public class AuthService
    {
        public static TokenDTO Authenticate(string uname, string pass)
        {
            var res= DataAccessFactory.AuthData().Authenticate(uname, pass);
            if (res)
            {
                var token = new Token();
                token.UserId= uname;
                token.CreatedAt= DateTime.Now;
                token.TKey= Guid.NewGuid().ToString();

                var ret=DataAccessFactory.TokenData().Create(token);
                if (ret != null)
                {
                    var cfg = new MapperConfiguration(c =>
                    {
                        c.CreateMap<Token, TokenDTO>();
                    });
                    var mapper = new Mapper(cfg);
                    var mapped = mapper.Map<TokenDTO>(ret);
                    return mapped;
                }
            }
            return null;
        }

        public static bool IsTokenValid(string tkey)
        {
            var exstToken = DataAccessFactory.TokenData().Read(tkey);
            if(exstToken != null && exstToken.DeletedAt == null )
            {
                return true;
            }
            return false;
        }
        public static bool Logout(string tkey)
        {
            var exstToken = DataAccessFactory.TokenData().Read(tkey);
            exstToken.DeletedAt = DateTime.Now;
            if(DataAccessFactory.TokenData().Update(exstToken) != null)
            {
                return true;
            }
            return false;
        }
    }
}
