using ASP.NET_Core_Web_API.Models;
using ASP.NET_Core_Web_API.Services;

namespace ASP.NET_Core_Web_API.Services___Implementations
{
    public class ShipmentService : IShipmentService
    {
        private readonly ICartService _cartService;

        public ShipmentService(ICartService cartService)
        {
            _cartService = cartService;
        }

        public string Ship(AddressInfo info, IEnumerable<Product> items)
        {
            var quantity = _cartService.TotalQuantity(items);
            var sum = _cartService.TotalSum(items);

            return $"Shipped {quantity} items to {info.City} on total sum {sum}";
        }
    }
}
