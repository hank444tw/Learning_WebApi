using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Learning_WebApi.Models;

using Newtonsoft.Json;
using AcceptVerbsAttribute = System.Web.Http.AcceptVerbsAttribute;

namespace Learning_WebApi.Controllers
{
    public class ValuesController : ApiController
    {
        db10861113Entities db = new db10861113Entities();

        // GET api/values
        [AcceptVerbsAttribute("GET","POST")]
        public IHttpActionResult Get()
        {
            var data = db.User;
            var str = db.User.ToList();
            return Json(str);
        }

        //// GET api/values/5
        //public IHttpActionResult Get(int id)
        //{
        //    User data = db.User.Find(id);
        //    if(data == null)
        //    {
        //        return NotFound();
        //    }

        //    return Json(data);
        //}

        //// POST api/values
        //public void Post([FromBody] string value)
        //{

        //}

        //// PUT api/values/5
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/values/5
        //public void Delete(int id)
        //{
        //}
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
