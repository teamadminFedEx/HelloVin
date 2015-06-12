using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HelloVin.Interfaces;
using HelloVin.Models.DataContract;

namespace HelloVin.Models
{
    public class VinChecker : IVinChecker
    {
         private IEnumerable<IVinRule> _vinRules;

         public VinChecker(IEnumerable<IVinRule> vinRules) 
         { 
            _vinRules = vinRules; 
         } 
 
 
         public CheckResultResponse Check(string vin) 
         {

            // Check each rule in the rule list
             bool result = _vinRules.All(x => x.Check(vin));

             var response = new CheckResultResponse();

             if (result)
             {
                 response.CheckResult = CheckResult.Ok;
             }
             else 
             {
                 response.CheckResult = CheckResult.Failed;
             }
             return response;
         } 
    }
}