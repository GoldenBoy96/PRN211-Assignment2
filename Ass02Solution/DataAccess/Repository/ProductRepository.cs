using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        private AssSalesContext _db;

        public ProductRepository()
        {
            _db = new AssSalesContext();
        }

        public void Create(Product product)
        {
            _db.Add(product);
            _db.SaveChanges();
        }

        public void Delete(int id)
        {
            Product product = GetProduct(id);
            _db.Remove(product);
            _db.SaveChanges();
        }

        public Product GetProduct(int id)
        {
            return _db.Products.ToList().FirstOrDefault(c => c.ProductId == id);
        }

        public List<Product> GetProducts() => this._db.Products.ToList();

        public void Update()
        {
            _db.SaveChanges();
        }
    }
}
