namespace ASP.NET_Core_Web_API.Models
{
    public class CheckoutRequest
    {
        public IEnumerable<Product> Items { get; set; }
        public Card Card { get; set; }
        public AddressInfo Address { get; set; }
    }
}
