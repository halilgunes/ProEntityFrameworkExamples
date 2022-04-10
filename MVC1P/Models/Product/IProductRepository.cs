using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC1P.Models
{
    public interface IProductRepository
    {
        IEnumerable<Product> Products { get; }
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void UpdateAll(Product[] product);
        Product GetProduct(long id);
        void DeleteProduct(long id);
    }
}
