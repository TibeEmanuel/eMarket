using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using eMarket.DataLayer;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Security.Claims;
using eMarket.Datalayer.Entities;
using eMarket.DataLayer.Entities;

namespace eMarket.Datalayer
{
    
    public class EmarketContext : IdentityDbContext<EmarketUser>
    {
        public EmarketContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer<EmarketContext>(new SampleData()); 
            
        }

        public static EmarketContext Create()
        {
            return new EmarketContext();
        }
       

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Subscription> Orders { get; set; }
        
    }

}
