using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionSample
{
    public interface IPaymentProcessor
    {
        void ChangeCreditCard(string creditCardNumber, string expiryDate);
    }
    public class PaymentProcessor : IPaymentProcessor
    {
        public void ChangeCreditCard(string creditCardNumber, string expiryDate)
        {
            if(string.IsNullOrEmpty(creditCardNumber))
            {
                throw new ArgumentException("Invalid Credit Card");
            }

            if(string.IsNullOrEmpty(expiryDate ))
            {
                throw new ArgumentException("Invalid Expiry Date");
            }

            Console.WriteLine("Call to credit card api");
        }
    }
}
