using HelloVin.Interfaces;

namespace HelloVin.Models
{
    public class VinLengthRule : IVinRule
    {
        public VinLengthRule() 
        { 
        } 

        public bool Check(string vin)
        {
            return vin.Length == 17;
        }
 
    }
}