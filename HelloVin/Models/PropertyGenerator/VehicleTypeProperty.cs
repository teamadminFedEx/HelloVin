using HelloVin.Interfaces;
using HelloVin.Models.Enums;

namespace HelloVin.Models.Properties
{
    public class VehicleTypeProperty : IVehiclePropertyGenerator
    {
        public IVehicleProperty GetVehicleProperty(string Vin)
        {
            var value = VehicleType.Unknown;
            if (Vin.ToUpper().StartsWith("YS4"))
            {
                value = VehicleType.Bus;
            }
            else if (Vin.ToUpper().StartsWith("YS2"))
            {
                value = VehicleType.Truck;
            }

            return new BaseProperty("VehicleType", value.ToString());
        }
    }
}