using System.Collections.Generic;
using HelloVin.Interfaces;

namespace HelloVin.Models.PropertyGenerator
{
    public class CountryProperty : IVehiclePropertyGenerator
    {
        public IEnumerable<string> SwedenVin()
        {
            for (char c = 'S'; c <= 'W'; c++)
            {
                yield return "Y" + c;
            }
        }

        public IVehicleProperty GetVehicleProperty(string vin)
        {
            return new BaseProperty("Country", GetCountry(vin));
        }

        private string GetCountry(string vin)
        {
            string country = vin.Substring(0, 2);
            switch (country)
            {
                case "YS":
                case "YT":
                case "YU":
                case "YV":
                case "YW":
                    return "Sweden";

                default:
                    return "Unknown";
                    
            }
        }
    }
}