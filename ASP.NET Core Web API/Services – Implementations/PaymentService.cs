using ASP.NET_Core_Web_API.Models;
using ASP.NET_Core_Web_API.Services;

namespace ASP.NET_Core_Web_API.Services___Implementations
{
    public class PaymentService : IPaymentService
    {
        public bool Charge(decimal totalPrice, Card card)
        {
            return card.ExpirationDate > DateTime.UtcNow;
        }
    }
}
