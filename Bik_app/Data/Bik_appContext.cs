using Bik_app.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bik_app.Data
{
    public class Bik_appContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }
        public DbSet<ProductSubcategory> ProductSubcategories { get; set; }


        public Bik_appContext(DbContextOptions<Bik_appContext> options)
        : base(options)
        { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasKey(p => p.ProductID);

            modelBuilder.Entity<ProductCategory>()
                .HasKey(p => p.ProductCategoryID);

            modelBuilder.Entity<ProductSubcategory>()
                .HasKey(p => p.ProductSubcategoryID);

            //modelBuilder.Entity<ProductCategory>()
            //    .Property(p => p.Mail)
            //    .IsRequired()
            //    .HasMaxLength(100);

            //modelBuilder.Entity<ProductSubcategory>()
            //    .Property(p => p.Password)
            //    .HasMaxLength(50)
            //    .IsRequired();
        }

    }
}
