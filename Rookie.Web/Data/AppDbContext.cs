using Microsoft.EntityFrameworkCore;
namespace Rookie.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Rookie.Web.Data

{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<Dev> Dev { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<ProductImage> ProductImage { get; set; }
        public DbSet<Publisher> Publisher { get; set; }
        public DbSet<Rating> Rating { get; set; }
        public DbSet<Role> Role { get; set; }
        public DbSet<Stock> Stock { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Genre>().ToTable("Genre");
            modelBuilder.Entity<Category>().ToTable("Category");
            modelBuilder.Entity<Address>().ToTable("Address");
            modelBuilder.Entity<User>().HasOne(db => db.User_Address).WithMany(db => db.Address_User).HasForeignKey(db => db.AddressID); 
        }
    }
}


