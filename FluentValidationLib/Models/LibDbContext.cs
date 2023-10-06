using Microsoft.EntityFrameworkCore;

namespace FluentValidationLib.Models
{
    public class LibDbContext : DbContext
    {
        public LibDbContext(DbContextOptions<LibDbContext> options) : base(options) 
        {
                
        }

        public DbSet<Customer> Customers { get; set; }
    }
}
