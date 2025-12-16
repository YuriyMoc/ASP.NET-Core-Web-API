using ASP.NET_Core_Web_API.Models;

namespace ASP.NET_Core_Web_API.Services
{
    public interface ICartService
    {
        decimal TotalSum(IEnumerable<Product> items);
        int TotalQuantity(IEnumerable<Product> items);
    }
}
