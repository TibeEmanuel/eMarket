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

namespace eMarket.Datalayer
{
    public class EmarketContext : IdentityDbContext<ApplicationUser>
    {
        public EmarketContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
            Database.SetInitializer<EmarketContext>(null); 
        }

        public static EmarketContext Create()
        {
            return new EmarketContext();
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<Image> Images { get; set; }
        public DbSet<Announcement> Announcements { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            // Configure Asp Net Identity Tables
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<User>().Property(u => u.PasswordHash).HasMaxLength(500);

            modelBuilder.Entity<User>().Property(u => u.PhoneNumber).HasMaxLength(50);

            modelBuilder.Entity<Image>().ToTable("Images");
            modelBuilder.Entity<Product>().ToTable("Products");
            modelBuilder.Entity<ProductCategory>().ToTable("ProductCategories");
            modelBuilder.Entity<Announcement>().ToTable("Announcements");
            modelBuilder.Entity<Order>().ToTable("Orders");
           
        }
    }

}
