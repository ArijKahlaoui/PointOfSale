using Microsoft.EntityFrameworkCore;
using POS.Models;

namespace POS.Data
{
    public class POSEntities : DbContext
    {
        public POSEntities(DbContextOptions<POSEntities> options): base(options)   
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductQuantity> ProductQuantities { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleDetail> SaleDetails { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
