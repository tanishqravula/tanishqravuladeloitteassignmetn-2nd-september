using WebApplication6.Models;

namespace WebApplication6.Services
{
    public interface IProductService
    {
        List<Product> GetAll();
        Product GetProductById(int id);
        void AddProduct(Product productobj);
        void UpdateProduct(Product productobj);
        void DeleteProduct(int id);


        List<Product> GetProductsByCategory(string category);
        List<Product> GetOutOfStockProducts();
        List<Product> GetProductsByPriceRange(decimal minPrice, decimal maxPrice);
        List<string> GetAllCategories();
    }
}
