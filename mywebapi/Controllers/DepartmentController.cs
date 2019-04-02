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
        static List<string> department = new List<string>()
        {
            "Wholesale", "Underwriting", "IT", "Retail", "Arrears"
        };

        // GET: api/Department
        public IEnumerable<string> Get()
        {
            return department;
        }

        // GET: api/Department/5
        public string Get(int id)
        {
            return department[id];
        }

        // POST: api/Department
        public void Post([FromBody]string value)
        {
            department.Add(value);
        }

        // PUT: api/Department/5
        public void Put(int id, [FromBody]string value)
        {
            department[id] = value;
        }

        // DELETE: api/Department/5
        public void Delete(int id)
        {
            department.RemoveAt(id);
        }
    }
}
