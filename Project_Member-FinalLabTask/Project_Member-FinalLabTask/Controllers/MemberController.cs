using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Project_Member_FinalLabTask.Controllers
{
    public class MemberController : ApiController
    {
        [HttpGet]
        [Route("api/member")]
        public HttpResponseMessage AllMembers()
        {
            try
            {
                var data = MemberService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/member/{id}")]
        public HttpResponseMessage FindMember(int id)
        {
            try
            {
                var data = MemberService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/member/create")]
        public HttpResponseMessage CreateMember(MemberDTO Member)
        {
            try
            {
                var data = MemberService.Insert(Member);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/member/update")]
        public HttpResponseMessage UpdateMember(MemberDTO Member)
        {
            try
            {
                var data = MemberService.Update(Member);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/member/delete/{id}")]
        public HttpResponseMessage DeleteMember(int id)
        {
            try
            {
                var data = MemberService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
