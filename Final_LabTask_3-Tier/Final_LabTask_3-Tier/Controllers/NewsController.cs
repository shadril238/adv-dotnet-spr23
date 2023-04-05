using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Final_LabTask_3_Tier.Controllers
{
    public class NewsController : ApiController
    {
        [HttpGet, Route("api/news")]
        public HttpResponseMessage AllNews()
        {
            try
            {
                var data = NewsService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPost, Route("api/news/find/{id}")]
        public HttpResponseMessage FindNews(int id)
        {
            try
            {
                var data=NewsService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPost, Route("api/news/create")]
        public HttpResponseMessage CreateNews(NewsDTO news)
        {
            try
            {
                var data=NewsService.Create(news);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost, Route("api/news/update")]
        public HttpResponseMessage UpdateNews(NewsDTO news)
        {
            try
            {
                var data = NewsService.Update(news);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpPost, Route("api/news/remove/{id}")]
        public HttpResponseMessage DeleteNews(int id)
        {
            try
            {
                var data = NewsService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

    }
}
