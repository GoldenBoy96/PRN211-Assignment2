using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderDetailRepository : IOrderDetailRepository
    {
        private AssSalesContext _db;

        public OrderDetailRepository()
        {
            _db = new AssSalesContext();
        }

        public void Create(OrderDetail orderDetail)
        {
            _db.Add(orderDetail);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            OrderDetail orderDetail = GetOrderDetail(id);
            _db.Remove(orderDetail);
            _db.SaveChanges();
        }

        public OrderDetail GetOrderDetail(int id)
        {
            return _db.OrderDetails.ToList().FirstOrDefault(c => c.OrderId == id);
        }

        public List<OrderDetail> GetOrderDetails() => this._db.OrderDetails.ToList();

        public void Update()
        {
            _db.SaveChanges();
        }
    }
}
