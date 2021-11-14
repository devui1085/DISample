using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionSample
{
    public interface IShippingProccessor
    {
        void MailProduct(Product product);
    }

    public class ShippingProccessor : IShippingProccessor
    {
        private IProductsStockRepository productStockRepository;
        public ShippingProccessor(IProductsStockRepository productsStockRepository)
        {
            this.productStockRepository = productStockRepository;
        }
        public void MailProduct(Product product)
        {
            productStockRepository.ReduceStock(product);

            Console.WriteLine("Call to shipping api");
        }
    }
}
