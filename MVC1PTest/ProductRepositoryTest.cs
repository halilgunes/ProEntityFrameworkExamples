using System;
using Xunit;
using MVC1P;
using Moq;
using MVC1P.Models;

namespace MVC1PTest
{
    public class ProductRepositoryTest
    {        
        public ProductRepositoryTest()
        {
        }

        [Fact]
        public void ProductCategory_ShouldReturn_One()
        {
            Mock<IProductRepository> repo = new Mock<IProductRepository>();
            repo.Setup(n => n.GetProduct(2)).Returns(new Product { CategoryId = 1, Name = "Elma", PurchasePrice = 10, RetailPrice = 5 });
            IProductRepository repository = repo.Object;
            Product P = repository.GetProduct(2);
            Assert.Equal(1, P.CategoryId);
        }
    }
}
