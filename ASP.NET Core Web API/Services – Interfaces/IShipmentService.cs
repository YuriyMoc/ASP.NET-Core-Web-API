using ASP.NET_Core_Web_API.Models;

namespace ASP.NET_Core_Web_API.Services
{
    public interface IShipmentService
    {
       string Ship(AddressInfo info, IEnumerable<Product> items);
        
    }
}
