using eShopBackendAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace eShopBackendAPI.Data
{
    public class StoreContext(DbContextOptions options) : DbContext(options)
    {
        public required DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=store.db");
            }
        }

    }
}
