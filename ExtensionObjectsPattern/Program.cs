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
            BeverageItem drink = new Cocoa(1.75M, 40, "Cocoa");

            IBeverageExtension sugar = new SugarExtension();

            drink.RegisterExtension(sugar);

            drink.GetInfo();

            //drink.UnregisterExtension(sugar);

            //drink.GetInfo();

            //Console.WriteLine($"Turi sugar?: {drink.HasExtension(sugar)}");

            Console.ReadKey();
        }
    }
}
