using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloVin.Controllers
{
    public class VinController : ApiController
    {
        // GET api/vin
        public IEnumerable<string> Get()
        {
            return new string[] { "YS298765432123456", "YS298765432123457" };
        }

        // GET api/vin/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/vin
        public void Post([FromBody]string value)
        {
        }

        // PUT api/vin/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/vin/5
        public void Delete(int id)
        {
        }
    }
}
