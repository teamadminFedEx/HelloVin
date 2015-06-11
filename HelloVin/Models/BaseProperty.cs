using HelloVin.Interfaces;

namespace HelloVin.Models
{
    public class BaseProperty :IVehicleProperty
    {
        public string Property { get; set; }
        public string Value { get; set; }

        public BaseProperty(string property, string value)
        {
            Property = property;
            Value = value;
        }
    }
}