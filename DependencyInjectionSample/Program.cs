using System;

namespace DependencyInjectionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = string.Empty;
            var orderManager = new OrderManager();
            while (product !="exit")
            {
                Console.WriteLine(@"Enter a product:
Keyboard = 0,
Mouse = 1,
Mic = 2,
Speaker = 3");
                product = Console.ReadLine();
                if(Enum.TryParse(product, out Product productEnum) )
                {
                    Console.WriteLine("Please enter a valid payment method: XXXXXXXX:MMYY");
                    var paymentMethod = Console.ReadLine();
                    if (string.IsNullOrEmpty(paymentMethod) || paymentMethod.Split(";").Length != 2)
                        throw new Exception("Invalid payment method.");
                    orderManager.Submit(productEnum, paymentMethod.Split(";")[0], paymentMethod.Split(";")[1]);
                    Console.WriteLine($"{productEnum.ToString()} has been shipped ");
                }
                else
                {
                    Console.WriteLine("Invalid Product");
                }

                Console.WriteLine(Environment.NewLine);
            }
        }
    }
}
 