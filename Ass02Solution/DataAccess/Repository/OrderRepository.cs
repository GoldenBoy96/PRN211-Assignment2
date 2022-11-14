using AutoMapper.Execution;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private AssSalesContext _db;

        public OrderRepository()
        {
            _db = new AssSalesContext();
        }

        public void Create(Order order)
        {
            _db.Add(order);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            Order order = GetOrder(id);
            _db.Remove(order);
            _db.SaveChanges();
        }

        public Order GetOrder(int id)
        {
            return _db.Orders.ToList().FirstOrDefault(c => c.OrderId == id);
        }

        public List<Order> GetOrders() => this._db.Orders.ToList();

        public void Update()
        {
            _db.SaveChanges();
        }
    }
}
