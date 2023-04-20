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
    public class ProjectController : ApiController
    {
        [HttpGet]
        [Route("api/project")]
        public HttpResponseMessage AllProjects()
        {
            try
            {
                var data = ProjectService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/project/{id}")]
        public HttpResponseMessage FindProject(int id)
        {
            try
            {
                var data = ProjectService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/project/create")]
        public HttpResponseMessage CreateProject(ProjectDTO Project) 
        {
            try
            {
                var data=ProjectService.Insert(Project);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/project/update")]
        public HttpResponseMessage UpdateProject(ProjectDTO Project)
        {
            try
            {
                var data = ProjectService.Update(Project);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/project/delete/{id}")]
        public HttpResponseMessage DeleteProject(int id) 
        {
            try
            {
                var data = ProjectService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
    }
}
