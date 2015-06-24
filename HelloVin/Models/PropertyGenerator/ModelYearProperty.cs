using System.Collections.Generic;
using HelloVin.Interfaces;

namespace HelloVin.Models.PropertyGenerator
{
    public class ModelYearProperty : IVehiclePropertyGenerator
    {
        IDictionary<string,string> _modelYearDictionary = new Dictionary<string, string> {
            {"S","1995"},
            {"T","1996"},
            {"V","1997"},
            {"W","1998"},
            {"X","1999"},
            {"Y","2000"},
            {"1","2001"},
            {"2","2002"},
            {"3","2003"},
            {"4","2004"},
            {"5","2005"},
            {"6","2006"},
            {"7","2007"},
            {"8","2008"},
            {"9","2009"},
            {"A","2010"},
            {"B","2011"},
            {"C","2012"},
            {"D","2013"},
            {"E","2014"},
            {"F","2015"},
            {"G","2016"},
            {"H","2017"},
            {"J","2018"},
            {"K","2019"},
            {"L","2020"}
        };

        public IVehicleProperty GetVehicleProperty(string Vin)
        {
            var modelYearIdentifier = Vin.Substring(9, 1).ToUpper();
            string value = "";

            if (!_modelYearDictionary.TryGetValue(modelYearIdentifier, out value))
            {
                value = "Unknown";
            }

            return new BaseProperty("ModelYear", value);
        }
    }
}