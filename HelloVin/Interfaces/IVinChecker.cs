using HelloVin.Models.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloVin.Interfaces
{
    public interface IVinChecker
    {
         CheckResultResponse Check(string vin); 
    } 
}
