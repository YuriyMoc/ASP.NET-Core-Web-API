using ASP.NET_Core_Web_API.Models;

namespace ASP.NET_Core_Web_API.Services
{
    public interface IDataProviderService
    {
        IEnumerable<Product> GetAll();
        Product GetByIndex(int index);
        void Add(Product product);
        void Update(int index, Product product);
        void Delete(int index);
    }
}
