using Microsoft.EntityFrameworkCore;

namespace WebApplication6.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }
        public string Email { get; set; }
    }
    public class SchoolDbContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options):base(options)
        {

        }
    }
}
