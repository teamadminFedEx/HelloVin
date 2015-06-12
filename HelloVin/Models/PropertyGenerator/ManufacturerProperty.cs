using System.Collections.Generic;
using System.Web.UI.WebControls;
using HelloVin.Interfaces;
using HelloVin.Models.Enums;

namespace HelloVin.Models.Properties
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

        public IVehicleProperty GetVehicleProperty(string Vin)
        {
            

            var value = VehicleManufacturer.Unknown;

            var toCheck = Vin.Substring(0, 3).ToUpper();
            if (ScaniaVin.Contains(toCheck))
            {
                value = VehicleManufacturer.Scania;
            }
            
            return new BaseProperty("Manufacturer", value.ToString());
        }
    }
}