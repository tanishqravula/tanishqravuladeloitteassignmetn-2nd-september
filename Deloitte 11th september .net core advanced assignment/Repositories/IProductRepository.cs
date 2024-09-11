using WebApplication6.Models;

namespace WebApplication6.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetAll();
        Product GetProductById(int id);
        void AddProduct(Product productobj);
        void UpdateProduct(Product productobj);
        void DeleteProduct(int id);
    }
}
