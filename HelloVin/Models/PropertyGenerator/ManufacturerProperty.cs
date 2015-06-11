using HelloVin.Interfaces;
using HelloVin.Models.Enums;

namespace HelloVin.Models.Properties
{
    public class ManufacturerProperty : IVehiclePropertyGenerator
    {
        public IVehicleProperty GetVehicleProperty(string Vin)
        {
            var companyIdentifier = Vin.Substring(0, 3);

            var value = VehicleManufacturer.Unknown;
            if (companyIdentifier.ToUpper() == "YS2")
            {
                value = VehicleManufacturer.Scania;
            }
            
            return new BaseProperty("Manufacturer", value.ToString());
        }
    }
}