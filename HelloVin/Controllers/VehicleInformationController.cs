using System.Collections.Generic;
using System.Web.Http;
using HelloVin.Interfaces;
using HelloVin.Models;
using HelloVin.Models.PropertyGenerator;

namespace HelloVin.Controllers
{
    public class VehicleInformationController : ApiController
    {

        public VehicleInformation Get(string id)
        {
            var propertyList = new List<IVehiclePropertyGenerator>
            {
                new ManufacturerProperty(),
                new VehicleTypeProperty(),
                new CountryProperty()
            };
            return (new VehicleInformation(propertyList, id));
        }

    }
}
