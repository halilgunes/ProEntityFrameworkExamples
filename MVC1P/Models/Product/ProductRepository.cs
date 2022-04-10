using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC1P.Models
{
    public class ProductRepository : IProductRepository
    {
        ProducDbDataContext dbContext;
        public ProductRepository(ProducDbDataContext dbDataContext)
        {
            dbContext = dbDataContext;
        }

        public IEnumerable<Product> Products
        {
            get
            {
                //return dbContext.Product;
                return dbContext.Product.Include(p => p.ProductCategory).ToArray();
            }
        }

        public void AddProduct(Product product)
        {
            dbContext.Product.Add(product);
            dbContext.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            var currentProduct = dbContext.Product.FirstOrDefault(n => n.Id == product.Id);
            currentProduct.Name = product.Name;
            //currentProduct.ProductCategory = product.ProductCategory;
            currentProduct.PurchasePrice = product.PurchasePrice;
            currentProduct.RetailPrice = product.RetailPrice;
            currentProduct.CategoryId = product.CategoryId;
            dbContext.SaveChanges();
        }

        public void UpdateAll(Product[] productArr)
        {
            //dbContext.Product.UpdateRange(productArr);
            Dictionary<long, Product> data = productArr.ToDictionary(p => p.Id);
            IEnumerable<Product> baseLine = dbContext.Product.Where(n => data.Keys.Contains(n.Id));//Dictionary'de id'si olanları çekiyor.
            foreach (Product currentProduct in baseLine)
            {
                Product requestProduct = data[currentProduct.Id];
                currentProduct.Name = requestProduct.Name;
                currentProduct.PurchasePrice = requestProduct.PurchasePrice;
                currentProduct.RetailPrice = requestProduct.RetailPrice;
                currentProduct.CategoryId = requestProduct.CategoryId;
            }
            dbContext.SaveChanges();
        }

        public Product GetProduct(long id)
        {
            //return dbContext.Product.FirstOrDefault(n => n.Id == id);
            return dbContext.Product.Include(p => p.ProductCategory).First(p=>p.Id == id);
        }

        public void DeleteProduct(long id)
        {
            var product = dbContext.Product.FirstOrDefault(n => n.Id == id);
            dbContext.Product.Remove(product);
            dbContext.SaveChanges();
        }
    }
}
