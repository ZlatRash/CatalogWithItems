using CatalogWithItemsData.Models;
using Microsoft.EntityFrameworkCore;

namespace CatalogWithItemsWebAPI.Data
{
    public class ProductsDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }

        public DbSet<Product> Products { get; set; }    

        public ProductsDbContext(DbContextOptions<ProductsDbContext> options): base(options)
        {

        }
    }
}
