using DecoratorPattern.Component;
using DecoratorPattern.ConcreteComponent;
using DecoratorPattern.ConcreteExtension;
using DecoratorPattern.Extension;
using DecoratorPattern.Helper;
using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BeverageItem drink = new Cocoa(1.75M, 40, "Cocoa");

            IBeverageExtension sugar = new SugarExtension();
            IBeverageExtension toppings = new ToppingsExtension();

            drink.RegisterExtension(sugar);
            drink.RegisterExtension(toppings);
            ((SugarExtension)sugar).AddSugar(3);
            //drink.UnregisterExtension(toppings);
            ((ToppingsExtension)toppings).AddTopping(new ToppingHelper.Topping[]
            {
                ToppingHelper.Topping.Chocolate,
                ToppingHelper.Topping.Cream
            });

            drink.GetInfo();
            //drink.UnregisterExtension(sugar);

            //drink.GetInfo();

            //Console.WriteLine($"Turi sugar?: {drink.HasExtension(sugar)}");

            Console.ReadKey();
        }
    }
}
