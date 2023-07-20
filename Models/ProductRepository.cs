using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ViewComponents.Models
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> _products = new List<Product>()
        {
            new Product() {ProductId=1, ProductName="Samsung S7", Price=3000, IsApproved=true, CategoryId=1},
            new Product() {ProductId=2, ProductName="Samsung S8", Price=4000, IsApproved=true, CategoryId=1},
            new Product() {ProductId=3, ProductName="Samsung S9", Price=5000, IsApproved=false, CategoryId=1},

            new Product() {ProductId=4, ProductName="Apple Ipad Gold", Price=4500, IsApproved=true, CategoryId=2},
            new Product() {ProductId=5, ProductName="Apple Ipad Silver", Price=5500, IsApproved=true, CategoryId=2},
            new Product() {ProductId=6, ProductName="Apple Ipad Mini", Price=6500, IsApproved=false, CategoryId=2},

            new Product() {ProductId=7, ProductName="Macbook Air", Price=7000, IsApproved=true, CategoryId=3},
            new Product() {ProductId=8, ProductName="Macbook Pro", Price=8000, IsApproved=true, CategoryId=3},
            new Product() {ProductId=9, ProductName="Macbook Silver", Price=9000, IsApproved=false, CategoryId=3}
        };
        public IEnumerable<Product> Products => _products;

        public void AddProduct(Product entity)
        {
            _products.Add(entity);
        }
    }
}