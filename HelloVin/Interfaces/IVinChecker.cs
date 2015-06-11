using HelloVin.Models.DataContract;

namespace HelloVin.Interfaces
{
    public interface IVinChecker
    {
         CheckResultResponse Check(string vin); 
    } 
}
