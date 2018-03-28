using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi2.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "Get by ID: {id}";
        }

        // POST api/values
        public string Post([FromBody]string value)
        {
            return "Post {value} success!";
        }

        // PUT api/values/5
        public string Put(int id, [FromBody]string value)
        {
            return "Put {value} success!";
        }

        // DELETE api/values/5
        public string Delete(int id)
        {
            return "Deleted {value}!";
        }
    }
}
