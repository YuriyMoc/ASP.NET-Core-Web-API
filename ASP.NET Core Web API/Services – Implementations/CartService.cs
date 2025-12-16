using ASP.NET_Core_Web_API.Models;
using ASP.NET_Core_Web_API.Services;

namespace ASP.NET_Core_Web_API.Services___Implementations
{
    public class CartService : ICartService
    {
        public decimal TotalSum(IEnumerable<Product> items)
        {
            return items.Sum(i => i.Price * i.Quantity);
        }

        public int TotalQuantity(IEnumerable<Product> items)
        {
            return items.Sum(i => i.Quantity);
        }
    }
}
