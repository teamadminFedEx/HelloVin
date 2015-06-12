using HelloVin.Interfaces;
using HelloVin.Models.Enums;

namespace HelloVin.Models.PropertyGenerator
{
    public class VehicleTypeProperty : IVehiclePropertyGenerator
    {
        public IVehicleProperty GetVehicleProperty(string vin)
        {
            var value = VehicleType.Unknown;
            if (vin.ToUpper().StartsWith("YS4"))
            {
                value = VehicleType.Bus;
            }
            else if (vin.ToUpper().StartsWith("YS2"))
            {
                value = VehicleType.Truck;
            }

            return new BaseProperty("VehicleType", value.ToString());
        }
    }
}