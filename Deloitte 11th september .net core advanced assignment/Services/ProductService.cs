using WebApplication6.Models;
using WebApplication6.Repositories;
namespace WebApplication6.Services
{
    public class ProductService : IProductService
    {
        public IProductRepository _repository;
        public ProductService(IProductRepository repository) { 
            _repository = repository; 
        }

        public void AddProduct(Product productobj)
        {
            _repository.AddProduct(productobj);
           
        }

        public void DeleteProduct(int id)
        {
            _repository.DeleteProduct(id);
            
        }

        public List<Product> GetAll()
        {
            return _repository.GetAll();
            
        }

        public Product GetProductById(int id)
        {
            return _repository.GetProductById(id);
            
        }

        public void UpdateProduct(Product productobj)
        {
            _repository.UpdateProduct(productobj);
            
        }
    }
}
