namespace ASP.NET_Core_Web_API.Controllers
{
    using ASP.NET_Core_Web_API.Models;
    using ASP.NET_Core_Web_API.Services;
    using Microsoft.AspNetCore.Mvc;

    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IDataProviderService _dataProvider;

        public ProductsController(IDataProviderService dataProvider)
        {
            _dataProvider = dataProvider;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_dataProvider.GetAll());
        }

        [HttpGet("{index}")]
        public IActionResult Get(int index)
        {
            return Ok(_dataProvider.GetByIndex(index));
        }

        [HttpPost]
        public IActionResult Post([FromBody] Product product)
        {
            _dataProvider.Add(product);
            return Ok();
        }

        [HttpPut("{index}")]
        public IActionResult Update(int index, [FromBody] Product product)
        {
            _dataProvider.Update(index, product);
            return Ok();
        }

        [HttpDelete("{index}")]
        public IActionResult Delete(int index)
        {
            _dataProvider.Delete(index);
            return Ok();
        }
    }
}
