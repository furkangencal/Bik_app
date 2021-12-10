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

            modelBuilder.Entity<Product>()
            .Property(b => b.MakeFlag)
            .HasDefaultValue(1);

            modelBuilder.Entity<Product>()
            .Property(b => b.FinishedGoodsFlag)
            .HasDefaultValue(1);

            modelBuilder.Entity<Product>()
                .HasAlternateKey(c => c.Name)
                .HasName("AK_Product_Name");

            modelBuilder.Entity<Product>()
                .HasAlternateKey(c => c.ProductNumber)
                .HasName("AK_Product_ProductNumber");

            modelBuilder.Entity<Product>()
                .HasAlternateKey(c => c.rowguid)
                .HasName("AK_Product_rowguid");

            modelBuilder.Entity<ProductCategory>()
                .HasKey(p => p.ProductCategoryID);

            modelBuilder.Entity<ProductCategory>()
                .HasAlternateKey(c => c.Name)
                .HasName("AK_ProductCategory_Name");

            modelBuilder.Entity<ProductCategory>()
                .HasAlternateKey(c => c.rowguid)
                .HasName("AK_ProductCategory_rowguid");

            modelBuilder.Entity<ProductSubcategory>()
                .HasKey(p => p.ProductSubcategoryID);

            modelBuilder.Entity<ProductSubcategory>()
                .HasAlternateKey(c => c.Name)
                .HasName("AK_ProductSubcategory_Name");

            modelBuilder.Entity<ProductSubcategory>()
                .HasAlternateKey(c => c.rowguid)
                .HasName("AK_ProductSubcategory_rowguid");

        }

    }
}
