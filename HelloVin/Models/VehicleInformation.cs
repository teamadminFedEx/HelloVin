using System.Collections.Generic;
using System.Linq;
using HelloVin.Interfaces;

namespace HelloVin.Models
{
    public class VehicleInformation
    {
        private IEnumerable<IVehiclePropertyGenerator> _vehicleProperties;

        public VehicleInformation(IEnumerable<IVehiclePropertyGenerator> vehicleProperties)
        {
            _vehicleProperties = vehicleProperties;
        }

        public IEnumerable<IVehicleProperty> Get(string Vin)
        {
           return _vehicleProperties.Select(x => x.GetVehicleProperty(Vin));
        } 
    }
}