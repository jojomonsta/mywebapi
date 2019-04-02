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
            new User { id = 1, name = "Johanna McMullen", email = "jojomonsta666@gamil.com", phone = "029223312235", role = 1 },
            new User { id = 2, name = "David McMullen", email = "howlingmadmucky@hotmail.co.uk", phone = "02920331235", role =  2},
            new User { id = 3, name = "Alexander Williams", email = "alexander.williams@hotmail.com" , phone = "02920564789", role = 2 },
            new User { id = 4, name = "George Turner", email = "johannamcmullen@hotmail.co.uk", phone = "02920456789", role = 2 },
            new User { id = 5, name = "Eloise McCarthy", email = "eloise.mccarthy@nhswales.co.uk", phone = "02920587478", role = 3 }
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
            var product = users.FirstOrDefault((p) => p.id == id);
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