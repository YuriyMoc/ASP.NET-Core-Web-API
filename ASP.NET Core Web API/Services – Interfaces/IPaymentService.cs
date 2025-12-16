using ASP.NET_Core_Web_API.Models;

namespace ASP.NET_Core_Web_API.Services
{
    public interface IPaymentService
    {
        bool Charge(decimal totalPrice, Card card);
    }
}
