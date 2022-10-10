using EF_CRUD_ReDo.DAL.Configuration;
using EF_CRUD_ReDo.DAL.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_CRUD_ReDo.DAL.Context
{
    public class EComerceDBContext : DbContext
    {
        public DbSet<Category> Category { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<District> Districts { get; set; }
        public DbSet<Customer> Customers { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-IPVME9J\YUNUS; Database=ECommerceDB; uid=sa; pwd=1234");

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Category>(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration<Product>(new ProductConfiguration());
            modelBuilder.ApplyConfiguration<Order>(new OrderConfiguration());
            modelBuilder.ApplyConfiguration<OrderDetail>(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration<City>(new CityConfiguration());
            modelBuilder.ApplyConfiguration<Country>(new CountryConfiguration());
            modelBuilder.ApplyConfiguration<District>(new DisctrictConfiguration());
            modelBuilder.ApplyConfiguration<Customer>(new CustomerConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}
