using System.Web.Http;
using HelloVin.Models.Enums;

namespace HelloVin.Controllers
{
    public class GetVehicleManufacturerController : ApiController
    {
        public VehicleManufacturer Get(string toCheck)
        {
            var companyIdentifier = toCheck.Substring(0, 3);
            if (companyIdentifier == "YS2")
            {
                return VehicleManufacturer.Scania;
            }
            return VehicleManufacturer.Unknown;
        }
    }
}