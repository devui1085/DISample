using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionSample
{
    public interface IOrderManager
    {
        void Submit(Product product, string creditCardNumber, string expiryDate);
    }
    public class OrderManager : IOrderManager
    {
        private IShippingProccessor shippingProccessor;
        private IPaymentProcessor paymentProcessor;
        private IProductsStockRepository productsStockRepository;
        public OrderManager(IShippingProccessor shippingProccessor,IPaymentProcessor paymentProcessor, IProductsStockRepository productsStockRepository)
        {
            this.shippingProccessor = shippingProccessor;
            this.paymentProcessor = paymentProcessor;
            this.productsStockRepository = productsStockRepository;
        }
        public void Submit(Product product, string creditCardNumber,string expiryDate)
        {
            if (!this.productsStockRepository.IsInStock(product))
                throw new Exception($"{product.ToString()} is not in stock!");
            this.paymentProcessor.ChangeCreditCard(creditCardNumber, expiryDate);
            shippingProccessor.MailProduct(product);

        }
    }
}
