using DependencyInjectionSample;
using System;
using Xunit;

namespace DependencyInjectionSampleTest
{
    public class OrderManagerTest
    {
        [Fact]
        public void Test1()
        {
            var orderManager = new OrderManager();
            orderManager.Submit(Product.Keyboard, "1000100010001000", "3344");
            Assert.ThrowsAny<Exception>(()=> orderManager.Submit(Product.Keyboard, "1000100010001000", "3344"));
        }
    }
}
