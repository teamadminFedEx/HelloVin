using System.Collections.Generic;
using HelloVin.Interfaces;
using HelloVin.Models.Enums;

namespace HelloVin.Models.PropertyGenerator
{
    public class ManufacturerProperty : IVehiclePropertyGenerator
    {
        public List<string> ScaniaVin = new List<string>
        {
            "YS2",
            "9BS",
            "YS4",
            "VLU"
        };

        public IVehicleProperty GetVehicleProperty(string vin)
        {
            var value = VehicleManufacturer.Unknown;

            var toCheck = vin.Substring(0, 3).ToUpper();
            if (ScaniaVin.Contains(toCheck))
            {
                value = VehicleManufacturer.Scania;
            }
            
            return new BaseProperty("Manufacturer", value.ToString());
        }
    }
}