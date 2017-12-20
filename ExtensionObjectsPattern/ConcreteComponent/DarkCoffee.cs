using DecoratorPattern.Component;
using System;

namespace DecoratorPattern.ConcreteComponent
{
    class DarkCoffee : BeverageItem
    {
        public int CoffeePercentage { get; set; }

        public DarkCoffee() : base(1.59M, 45, "Black coffee")
        {
            CoffeePercentage = 20;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Coffee percentage: {CoffeePercentage}%");
        }
    }
}
