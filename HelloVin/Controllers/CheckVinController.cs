using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HelloVin.Models;
using HelloVin.Interfaces;

namespace HelloVin.Controllers
{
    public class CheckVinController : ApiController
    {
        // GET api/checkvin/id
        public string Get(string id)
        {
            IVinChecker checker = new VinChecker(new List<IVinRule> 
                 { 
                     new VinLengthRule() 
                 });

            return checker.Check(id);
        }
    }
}
