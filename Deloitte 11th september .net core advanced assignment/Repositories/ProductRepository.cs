using WebApplication6.Models;
using WebApplication6.Repositories;
namespace WebApplication6.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public SalesDbContext _salescontext;
        public ProductRepository(SalesDbContext salescontext)
        {
            _salescontext = salescontext;
        }
        public void AddProduct(Product productobj)
        {
            _salescontext.Products.Add(productobj);
            _salescontext.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            Product products = _salescontext.Products.Find(id);
            _salescontext.Products.Remove(products);
            _salescontext.SaveChanges();
            
        }

        public List<Product> GetAll()
        {
            List<Product> products = _salescontext.Products.ToList();
            return products;
            
        }

        public Product GetProductById(int id)
        {
            Product products = _salescontext.Products.Find(id);
            return products;

            
        }

        public void UpdateProduct(Product productobj)
        {
            _salescontext.Products.Update(productobj);
            _salescontext.SaveChanges();
           
        }
    }
}
