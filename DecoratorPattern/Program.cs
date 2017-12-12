using DecoratorPattern.ConcreteComponent;
using DecoratorPattern.ConcreteDecorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Latte latte = new Latte(45, 1.89M, 45, "Coffee with milk");
            latte.MakeDrink();
            Console.WriteLine();

            Cocoa cocoa = new Cocoa(15, 1.59M, 30, "Cocoa");
            SugarDecorator sugarDecorator = new SugarDecorator(cocoa, 0.05M);
            sugarDecorator.AddSugar(4);
            ToppingsDecorator toppingsDecorator = new ToppingsDecorator(sugarDecorator);
            toppingsDecorator.AddTopping(Helper.ToppingHelper.Topping.Cinamon);
            toppingsDecorator.MakeDrink();
            Console.ReadKey();
        }
    }
}
