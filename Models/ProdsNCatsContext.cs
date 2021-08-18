using Microsoft.EntityFrameworkCore;

namespace ProdsNCats.Models
{
    public class ProdsNCatsContext : DbContext
    {
        public ProdsNCatsContext(DbContextOptions options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}