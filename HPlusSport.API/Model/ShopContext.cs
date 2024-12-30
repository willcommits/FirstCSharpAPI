
using Microsoft.EntityFrameworkCore;

namespace HPlusSport.API.Model
{
    public class ShopContext:DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options):base(options) {}
        protected override void OnModelCreating(ModelBuilder modelBuilder)

        {
            modelBuilder.Entity<Category>().HasMany(c=>c.Products).
                WithOne(a=>a.category).
                HasForeignKey(a=>a.CategoryId);

            modelBuilder.Seed();
        }
        public DbSet<Products>Products { get; set; }
        public DbSet<Category>Categories { get; set; }
    }
}
