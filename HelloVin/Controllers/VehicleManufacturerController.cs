using System.Web.Http;
using HelloVin.Models.Enums;

namespace HelloVin.Controllers
{
    public class VehicleManufacturerController : ApiController
    {
        public VehicleManufacturer Get(string VinNumber)
        {
            var companyIdentifier = VinNumber.Substring(0, 3);
            if (companyIdentifier.ToUpper() == "YS2")
            {
                return VehicleManufacturer.Scania;
            }
            return VehicleManufacturer.Unknown;
        }
    }
}