using DecoratorPattern.ConcreteComponent;
using DecoratorPattern.ConcreteDecorator;
using System;
using DecoratorPattern.Helper;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ToppingsDecorator toppingsDecorator = new ToppingsDecorator(new SugarDecorator(new Cocoa()));
            //sugarDecorator.AddSugar(3);

            if (toppingsDecorator.CheckRole(typeof(SugarDecorator)))
            {
                var item = (SugarDecorator)toppingsDecorator.GetRole(typeof(SugarDecorator));
                item.AddSugar(3);
            }

            toppingsDecorator.AddTopping(new ToppingHelper.Topping[]
            {
                ToppingHelper.Topping.Cream,
                ToppingHelper.Topping.Chocolate
            });
            toppingsDecorator.MakeDrink();
            Console.ReadKey();
        }
    }
}
