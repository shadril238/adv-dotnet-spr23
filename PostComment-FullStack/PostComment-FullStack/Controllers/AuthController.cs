using BLL.Services;
using PostComment_FullStack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PostComment_FullStack.Controllers
{
    public class AuthController : ApiController
    {
        [HttpPost]
        [Route("api/login")]
        public HttpResponseMessage Login(LoginModel login)
        {
            try
            {
                var res=AuthService.Authenticate(login.Uname, login.Password);
                if(res != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, res);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.NotFound, new {Message="User not found."});
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Message = ex.Message});
            }
        }

    }
}
