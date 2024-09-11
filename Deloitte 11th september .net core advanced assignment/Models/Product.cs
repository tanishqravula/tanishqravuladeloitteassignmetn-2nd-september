using Microsoft.EntityFrameworkCore;

namespace WebApplication6.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string UnitPrice { get; set; }
        public string  Quantity { get; set; }
        public string Category { get; set; }
    }
    public class SalesDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public SalesDbContext(DbContextOptions<SalesDbContext> options) : base(options) { }

    }
}
