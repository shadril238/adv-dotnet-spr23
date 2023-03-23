using API_CRUD.EF;
using API_CRUD.EF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace API_CRUD.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpGet]
        [Route("api/employees")]
        public HttpResponseMessage AllEmployees()
        {
            EmpContext db=new EmpContext();
            var employees = db.Employees.ToList();
            if(employees.Count > 0 )
            {
                return Request.CreateResponse(HttpStatusCode.OK,employees);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound);
        }
        [HttpGet]
        [Route("api/employees/{id}")]
        public HttpResponseMessage GetEmployee(int id)
        {
            EmpContext db = new EmpContext();
            var data = db.Employees.Find(id);
            if (data != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "User not found");
        }
        [HttpPost]
        [Route("api/employees/add")]
        public HttpResponseMessage AddEmp(Employee emp)
        {
            EmpContext db = new EmpContext();
            try
            {

                db.Employees.Add(emp);
                db.SaveChanges();
                return Request.CreateResponse(HttpStatusCode.OK, "Inserted");
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
            }
        }
        [HttpPost]
        [Route("api/employees/update")]
        public HttpResponseMessage EditEmp(Employee emp)
        {
            EmpContext db = new EmpContext();
            var exemp = db.Employees.Find(emp.Id);
            if (exemp != null)
            {
                try
                {
                    db.Entry(exemp).CurrentValues.SetValues(emp);
                    db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, "Updated");

                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
                }
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Employee Not found");
        }
        [HttpPost]
        [Route("api/employees/delete/{id}")]
        public HttpResponseMessage DeleteEmp(int id)
        {
            EmpContext db = new EmpContext();
            var emp = db.Employees.Find(id);
            if(emp != null)
            {
                try
                {
                    db.Employees.Remove(emp);
                    db.SaveChanges();
                    return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
                }
                catch (Exception ex)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, ex.Message);
                }
            }
            return Request.CreateResponse(HttpStatusCode.NotFound, "Employee Not found");

        }
    }
}
