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
        static List<string> jobType = new List<string>()
        {            
            "Senior Tester"
        };
        // GET: api/JobType
        public IEnumerable<string> Get()
        {
            return jobType;
        }

        // GET: api/JobType/5
        public string Get(int id)
        {
            return jobType[id];
        }

        // POST: api/JobType
        public string Post([FromBody]string value)
        {
            jobType.Add(value);
            return "Job Type Added";
        }

        // PUT: api/JobType/5
        public string Put(int id, [FromBody]string value)
        {
            jobType[id] = value;
            return "Job Type amended";
        }

        // DELETE: api/JobType/5
        public string Delete(int id)
        {
            jobType.RemoveAt(id);
            return "Job Type deleted";
        }
    }
}
