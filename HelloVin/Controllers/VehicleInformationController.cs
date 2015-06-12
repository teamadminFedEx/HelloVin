using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HelloVin.Interfaces;
using HelloVin.Models;
using HelloVin.Models.Properties;

namespace HelloVin.Controllers
{
    public class VehicleInformationController : ApiController
    {

        public VehicleInformation Get(string id)
        {
            var propertyList = new List<IVehiclePropertyGenerator>()
            {
                new ManufacturerProperty(),
                new VehicleTypeProperty(),
                new ModelYearProperty()
            };
            return (new VehicleInformation(propertyList, id));
        }

    }
}
