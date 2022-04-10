using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC1P.Models.Orders
{
    public class OrdersRepository : IOrderRepository
    {
        private ProducDbDataContext context;
        public OrdersRepository(ProducDbDataContext context) => this.context = context;

        public IEnumerable<Order> Orders => context.Order
              .Include(o => o.Lines)
              .ThenInclude(l => l.Product);

        public void AddOrder(Order order)
        {
            context.Order.Add(order);
            context.SaveChanges();
        }

        public void DeleteOrder(Order order)
        {
            context.Order.Remove(order);
            context.SaveChanges();
        }

        public Order GetOrder(long key)
        {
            // Order + .Inlclue(Line) + key == orderId.
            return context.Order
                .Include(l => l.Lines) //Order'ları çekerken ilgili Line tablolarını da çek.
                .FirstOrDefault(o => o.Id == key);
        }

        public void UpdateOrder(Order order)
        {
            context.Order.Update(order);
            context.SaveChanges();
        }
    }
}
