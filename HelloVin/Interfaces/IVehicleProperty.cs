using System.Security.Cryptography.X509Certificates;

namespace HelloVin.Interfaces
{
    public interface IVehicleProperty
    {
        string Property { get; set; }
        string Value { get; set; }
    }
}