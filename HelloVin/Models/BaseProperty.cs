using System.Runtime.Serialization;
using HelloVin.Interfaces;

namespace HelloVin.Models
{
    public class BaseProperty : IVehicleProperty, ISerializable 
    {
        public string Property { get; set; }
        public string Value { get; set; }

        public BaseProperty(string property, string value)
        {
            Property = property;
            Value = value;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue(Property, Value);
        }
    }
}