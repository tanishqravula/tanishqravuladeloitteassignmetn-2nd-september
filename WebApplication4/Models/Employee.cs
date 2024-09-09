using Microsoft.EntityFrameworkCore;

namespace WebApplication4.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Job { get; set; }
        public int salary { get; set; }
        public string Department { get; set; }

        internal List<Employee> ToList()
        {
            throw new NotImplementedException();
        }
    }
    
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<User> Users { get; set; }
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options) : base(options) { }

        protected EmployeeDbContext()
        {
        }
    }
}
