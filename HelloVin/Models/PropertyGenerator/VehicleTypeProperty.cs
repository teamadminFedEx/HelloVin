using HelloVin.Interfaces;

namespace HelloVin.Models.Properties
{
    public class VehicleTypeProperty : IVehiclePropertyGenerator
    {
        public IVehicleProperty GetVehicleProperty(string Vin)
        {
            return new BaseProperty("Unknown", "Unknown");
        }
    }
}