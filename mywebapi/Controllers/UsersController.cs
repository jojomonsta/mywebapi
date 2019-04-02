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
    public class UsersController : ApiController
    {

        private User[] users = new User[]
        {
            new User { Id = 1, Name = "Johanna McMullen", Email = "jojomonsta666@gamil.com", Phone = "029223312235", Role = 1 },
            new User { Id = 2, Name = "David McMullen", Email = "howlingmadmucky@hotmail.co.uk", Phone = "02920331235", Role =  2},
            new User { Id = 3, Name = "Alexander Williams", Email = "alexander.williams@hotmail.com" , Phone = "02920564789", Role = 2 },
            new User { Id = 4, Name = "George Turner", Email = "johannamcmullen@hotmail.co.uk", Phone = "02920456789", Role = 2 },
            new User { Id = 5, Name = "Eloise McCarthy", Email = "eloise.mccarthy@nhswales.co.uk", Phone = "02920587478", Role = 3 }
        };

        // GET: api/Users
        [ResponseType(typeof(IEnumerable<User>))]
        public IEnumerable<User> Get()
        {
            return users;
        }

        // GET: api/Users/5
        public IHttpActionResult Get(int id)
        {
            var product = users.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        // POST: api/Users
        public void Post([FromBody]User user)
        {
            
            //user.id = 6;
            //user.name = "Jordan 'Princess' Smith";
            //user.email = "princesssmith@optimum.com";
            //user.phone = "02922666555";
            //user.role = 4;            
        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]User user)
        {
            users[id] = user;
        }

        // DELETE: api/Users/5
        public void Delete(int id)
        {
        }
    }
}