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

        public List<string> VolvoVin = new List<string>
        {
            "YV1",
            "YV2",
            "YV3",
            "YV4",
            "4V1", 
            "4V2", 
            "4V3", 
            "4V4", 
            "4V5", 
            "4V6", 
            "4VL", 
            "4VM", 
            "4VZ"
        };

        public IVehicleProperty GetVehicleProperty(string Vin)
        {
            

            var value = VehicleManufacturer.Unknown;

            var toCheck = Vin.Substring(0, 3).ToUpper();
            if (ScaniaVin.Contains(toCheck))
            {
                value = VehicleManufacturer.Scania;
            }
            else if (VolvoVin.Contains(toCheck))
            {
                value = VehicleManufacturer.Scania;
            }
            
            return new BaseProperty("Manufacturer", value.ToString());
        }
    }
}