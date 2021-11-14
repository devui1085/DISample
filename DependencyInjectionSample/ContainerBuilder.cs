using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionSample
{
    public class ContainerBuilder
    {
        public IServiceProvider Build()
        {
            var container = new ServiceCollection();

            container.AddSingleton<IOrderManager, OrderManager>();
            container.AddSingleton<IPaymentProcessor, PaymentProcessor>();
            container.AddSingleton<IProductsStockRepository, ProductsStockRepository>();
            container.AddSingleton<IShippingProccessor, ShippingProccessor>();


            return container.BuildServiceProvider();
        }
    }
}
