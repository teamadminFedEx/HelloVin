﻿using System.Collections.Generic;
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
        public List<string> RenaultVin = new List<string>
        {
            "8A1",
            "93Y", 
            "9FB", 
            "KNM", 
            "L56", 
            "VF1", 
            "VF6"
        };

        public List<string> ManVin = new List<string>
        {
            "LZM", 
            "WMA"
        };

        public List<string> IvecoVin = new List<string>
        {
            "XLR", 
            "XLV"
        };

        public IVehicleProperty GetVehicleProperty(string vin)
        {
            var value = VehicleManufacturer.Unknown;

            var toCheck = vin.Substring(0, 3).ToUpper();
            if (ScaniaVin.Contains(toCheck))
            {
                value = VehicleManufacturer.Scania;
            }
            else if (VolvoVin.Contains(toCheck))
            {
                value = VehicleManufacturer.Volvo;
            }
            else if (RenaultVin.Contains(toCheck))
            {
                value = VehicleManufacturer.Renault;
            }
            else if (ManVin.Contains(toCheck))
            {
                value = VehicleManufacturer.Man;
            }
            else if (IvecoVin.Contains(toCheck))
            {
                value = VehicleManufacturer.Iveco;
            }
            
            return new BaseProperty("Manufacturer", value.ToString());
        }
    }
}