using Bik_app.Data;
using Bik_app.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bik_app.Repository
{
    public interface IRepository
    {
        Task<List<Product>> GetProduct();
        int AddSubCategory(ProductSubcategory productSubcategory);
    }

    public class Repository : IRepository
    {
        private readonly Bik_appContext db;
        public Repository(Bik_appContext context)
        {
            db = context;
        }

        public int AddSubCategory(ProductSubcategory productSubcategory)
        {
            db.ProductSubcategories.Add(productSubcategory);
            return db.SaveChanges();
        }

        public async Task<List<Product>> GetProduct()
        {
            var products = await db.Products.ToListAsync();

            return products;
        }

       
    }
}
