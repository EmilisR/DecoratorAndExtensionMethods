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
            BeverageItem drink = new Latte();

            IBeverageExtension sugar = new SugarExtension();
            IBeverageExtension toppings = new ToppingsExtension();
            drink.RegisterExtension(sugar);
            drink.RegisterExtension(toppings);

            if (drink.HasExtension(sugar))
            {
                ((SugarExtension)drink.GetExtension("SugarExtension")).AddSugar(3);
            }

            if (drink.HasExtension(toppings))
            {
                ((ToppingsExtension)drink.GetExtension("ToppingsExtension")).AddTopping(new ToppingHelper.Topping[]
                    {
                        ToppingHelper.Topping.Caramel,
                        ToppingHelper.Topping.Chocolate
                    });
            }

            drink.GetInfo();

            //drink.UnregisterExtension(sugar);

            //drink.GetInfo();

            //Console.WriteLine($"Turi sugar?: {drink.HasExtension(sugar)}");

            Console.ReadKey();
        }
    }
}
