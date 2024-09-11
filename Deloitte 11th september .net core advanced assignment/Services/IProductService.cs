using WebApplication6.Models;
using WebApplication6.Repositories;
namespace WebApplication6.Services
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetProductById(int id);
        void AddProduct(Product productobj);
        void UpdateProduct(Product productobj);
        void DeleteProduct(int id);
    }
}
