using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC1P.Models;
using MVC1P.Models.Orders;

namespace MVC1P.Controllers
{
    public class OrderController : Controller
    {
        private IOrderRepository orderRepository;
        private IProductRepository productRepository;

        public OrderController(IOrderRepository orderRepository, IProductRepository productRepository)
        {
            this.orderRepository = orderRepository;
            this.productRepository = productRepository;
        }

        public IActionResult Index() => View(orderRepository.Orders);

        public IActionResult EditOrder(long Id)
        {
            var products = productRepository.Products;//productlaı çek
            Order order = (Id == 0) ? new Order() : orderRepository.GetOrder(Id);//Order'ı çek
            IDictionary<long, OrderLine> lineMaps = order.Lines?.ToDictionary(l => l.ProductId)//Order'daki lineları product bzında dictionarye al
                ?? new Dictionary<long, OrderLine>();

            //Bütün ürünleri listeliyor. Siparişte olana ait quantity vs bilgisi oluyor. Diğerleri default değerlerle geliyor.
            ViewBag.Lines = products.Select(p => lineMaps.ContainsKey(p.Id)//lineMaps içinde olan product ise o line'ı dön.
                ? lineMaps[p.Id]
                : new OrderLine { Product = p, ProductId = p.Id, Quantity = 0 });//Line'lar içinde yoksa product yeni bir Line nesnesi dön.
            return View(order);
        }

        [HttpPost]
        public IActionResult AddOrUpdateOrder(Order order)
        {
            order.Lines = order.Lines.Where(l => l.Id > 0 || (l.Id == 0 && l.Quantity > 0)).ToArray();
            if (order.Id == 0)
            {
                orderRepository.AddOrder(order);

            }
            else
            {
                orderRepository.UpdateOrder(order);
            }
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult DeleteOrder(Order order)
        {
            orderRepository.DeleteOrder(order);
            return RedirectToAction(nameof(Index));
        }

    }
}
