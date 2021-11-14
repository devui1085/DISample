using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionSample
{
    public interface IProductsStockRepository
    {
        bool IsInStock(Product product);
        void ReduceStock(Product product);
        void AddStock(Product product);
    }
    public class ProductsStockRepository : IProductsStockRepository
    {
        private static Dictionary<Product, int> _productStockDatabase = setup();
        private static Dictionary<Product, int> setup()
        {
            var productStockDatabase = new Dictionary<Product, int>();
            productStockDatabase.Add(Product.Keyboard, 1);
            productStockDatabase.Add(Product.Mic, 1);
            productStockDatabase.Add(Product.Mouse, 1);
            productStockDatabase.Add(Product.Speaker, 1);

            return productStockDatabase;
        }

        public bool IsInStock(Product product)
        {
            Console.WriteLine("Call Get On Database");
            return _productStockDatabase[product] > 0;
        }

        public void ReduceStock(Product product)
        {
            Console.WriteLine("Call Update On Database");
            _productStockDatabase[product]--;
        }

        public void AddStock(Product product)
        {
            Console.WriteLine("Call Update On Database");
            _productStockDatabase[product]++;
        } 
    }
}
