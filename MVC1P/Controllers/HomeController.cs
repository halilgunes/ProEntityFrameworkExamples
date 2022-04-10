using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC1P.Models;

namespace MVC1P.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IProductRepository productRepository;
        private ICategoryRepository categoryRepository;

        public HomeController(ILogger<HomeController> logger, IProductRepository productRepository, ICategoryRepository categoryRepository)
        {
            _logger = logger;
            this.productRepository = productRepository;
            this.categoryRepository = categoryRepository;
        }

        public IActionResult Index()
        {
            return View(GetProductListAndCategory());
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            productRepository.AddProduct(product);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult UpdateProduct(long key)
        {
            //TODO: ProductListAndCategory clasını geçmemi gerekiyor.
            ViewBag.Categories = categoryRepository.Categories;
            return View(key == 0 ? new Product() : productRepository.GetProduct(key));
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            if (product.Id == 0)
            {
                productRepository.AddProduct(product);
            }
            else
            {
                productRepository.UpdateProduct(product);
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult UpdateAll()
        {
            ViewBag.UpdateAll = true;
            return View(nameof(Index), GetProductListAndCategory());
        }

        [HttpPost]
        public IActionResult UpdateAll(ProductListAndCategory productAndCategory)
        {
            productRepository.UpdateAll(productAndCategory.Products.ToArray());
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult DeleteProduct(long id)
        {
            productRepository.DeleteProduct(id);
            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private ProductListAndCategory GetProductListAndCategory()
        {
            ProductListAndCategory passData = new ProductListAndCategory();
            passData.Categories = categoryRepository.Categories;
            passData.Products = productRepository.Products;
            return passData;
        }
    }
}
