using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMarket.DataLayer
{
    public class EmarketContext : DbContext
    {
        public EmarketContext()
        {
            Database.SetInitializer<EmarketContext>(new CreateDatabaseIfNotExists<EmarketContext>()); 
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
 
    }
}
