using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using mywebapi.Models;

namespace mywebapi.Controllers
{
    public class DepartmentController : ApiController
    {
        private Department[] depts = new Department[]
        {
            new Department { deptName = "IT"},
            new Department { deptName = "Wholesale"},
            new Department {deptName = "Underwriting"}
        };

        // GET: api/Department
        [ResponseType(typeof(IEnumerable<Department>))]
        public IEnumerable<Department> Get()
        {
            return depts;
        }

        // GET: api/Department/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Department
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Department/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Department/5
        public void Delete(int id)
        {
        }
    }
}
