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
    public class JobTypeController : ApiController
    {
        private JobType[] jobType = new JobType[]
        {
            new JobType { jobtype = "Admin"},
            new JobType { jobtype = "Developer"},
            new JobType { jobtype = "Senior Tester"}
        };
        // GET: api/JobType
        [ResponseType(typeof(IEnumerable<JobType>))]
        public IEnumerable<JobType> Get()
        {
            return jobType;
        }

        // GET: api/JobType/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/JobType
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/JobType/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/JobType/5
        public void Delete(int id)
        {
        }
    }
}
