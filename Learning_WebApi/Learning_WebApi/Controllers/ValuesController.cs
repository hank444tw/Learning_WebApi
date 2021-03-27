using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Learning_WebApi.Models;

using Newtonsoft.Json;

namespace Learning_WebApi.Controllers
{
    public class ValuesController : ApiController
    {
        db10861113Entities db = new db10861113Entities();

        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public IHttpActionResult Get(int id)
        {
            User data = db.User.Find(id);
            if(data == null)
            {
                return NotFound();
            }
            string jsonData = JsonConvert.SerializeObject(data);

            return Ok(jsonData);
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
