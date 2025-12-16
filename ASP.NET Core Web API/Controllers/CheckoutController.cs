namespace ASP.NET_Core_Web_API.Controllers
{
    using ASP.NET_Core_Web_API.Models;
    using ASP.NET_Core_Web_API.Services;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class CheckoutController : ControllerBase
    {
        private readonly ICartService _cartService;
        private readonly IPaymentService _paymentService;
        private readonly IShipmentService _shipmentService;

        public CheckoutController(
            ICartService cartService,
            IPaymentService paymentService,
            IShipmentService shipmentService)
        {
            _cartService = cartService;
            _paymentService = paymentService;
            _shipmentService = shipmentService;
        }

        [HttpPost]
        public IActionResult ConductCheckout([FromBody] CheckoutRequest request)
        {
            var totalSum = _cartService.TotalSum(request.Items);
            var charged = _paymentService.Charge(totalSum, request.Card);

            if (!charged)
            {
                return Ok("not charged");
            }

            var result = _shipmentService.Ship(request.Address, request.Items);
            return Ok(result);
        }
    }
}
