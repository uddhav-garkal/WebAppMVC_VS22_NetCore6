using WebAppMVC_VS22_NetCore6.Models;

namespace WebAppMVC_VS22_NetCore6.Services
{
    public interface IProductService
    {
         List<Product> GetProducts();
    }
}