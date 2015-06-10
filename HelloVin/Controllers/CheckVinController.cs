using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloVin.Controllers
{
    public class CheckVinController : ApiController
    {
        // GET api/checkvin/id
        public string Get(string id)
        {
            if (id.Length == 17) return "Ok!!";
            else return "Not ok!";
        }
    }
}
