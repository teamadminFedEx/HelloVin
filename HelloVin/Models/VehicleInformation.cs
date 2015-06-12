using System.Collections.Generic;
using System.Linq;
using HelloVin.Interfaces;

namespace HelloVin.Models
{
    public class VehicleInformation
    {
        public IEnumerable<IVehicleProperty> VehicleProperties;

        public VehicleInformation(IEnumerable<IVehiclePropertyGenerator> propertyGenerators, string vin)
        {
            VehicleProperties = propertyGenerators.Select(x => x.GetVehicleProperty(vin));
        }


    }
}