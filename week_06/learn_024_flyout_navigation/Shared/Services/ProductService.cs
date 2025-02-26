using Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Services
{
    public class ProductService
    {
        private List<Product> _products = [];

        public void Add(Product products)
        {
            _products.Add(products);
        }

        public IEnumerable<Product> GetAll()
        {
            return _products;
        }

        public Product GetOne(Func<Product, bool> predicate)
        {
            var product = _products.FirstOrDefault(predicate);
            return product ?? null!;
        }

        public void Delete(Product product)
        {
            _products.Remove(product);
        }
    }
}
