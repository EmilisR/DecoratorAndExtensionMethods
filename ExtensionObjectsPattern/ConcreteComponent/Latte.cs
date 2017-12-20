using DecoratorPattern.Component;
using System;

namespace DecoratorPattern.ConcreteComponent
{
    class Latte : BeverageItem
    {
        public int MilkPercentage { get; set; }

        public Latte() : base(2.09M, 50, "Coffee with milk")
        {
            MilkPercentage = 55;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Milk percentage: {MilkPercentage}%");
        }
    }
}
