using DecoratorPattern.Component;
using DecoratorPattern.ConcreteComponent;
using DecoratorPattern.ConcreteExtension;
using DecoratorPattern.Extension;
using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BeverageItem drink = new Cocoa();

            IBeverageExtension sugar = new SugarExtension();
            drink.RegisterExtension(sugar);
            
            if (drink.HasExtension(sugar))
            {
                ((SugarExtension)sugar).AddSugar(3);
            }

            drink.GetInfo();

            //drink.UnregisterExtension(sugar);

            //drink.GetInfo();

            //Console.WriteLine($"Turi sugar?: {drink.HasExtension(sugar)}");

            Console.ReadKey();
        }
    }
}
