using ASP.NET_Core_Web_API.Models;
using ASP.NET_Core_Web_API.Services;

namespace ASP.NET_Core_Web_API.Services___Implementations
{
    public class DataProviderService : IDataProviderService
    {
        private readonly List<Product> _products = new();

        public IEnumerable<Product> GetAll() => _products;

        public Product GetByIndex(int index) => _products[index];

        public void Add(Product product) => _products.Add(product);

        public void Update(int index, Product product) => _products[index] = product;

        public void Delete(int index) => _products.RemoveAt(index);
    }
}
