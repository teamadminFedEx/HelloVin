using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HelloVin.Interfaces;

namespace HelloVin.Models
{
    public class VinChecker : IVinChecker
    {
         private IEnumerable<IVinRule> _vinRules;

         public VinChecker(IEnumerable<IVinRule> vinRules) 
         { 
            _vinRules = vinRules; 
         } 
 
 
         public string Check(string vin) 
         {

            // Check each rule in the rule list
             bool result = _vinRules.All(x => x.Check(vin));

             if (result) return ("Ok!!");
             else return ("Not Ok!");
         } 
    }
}