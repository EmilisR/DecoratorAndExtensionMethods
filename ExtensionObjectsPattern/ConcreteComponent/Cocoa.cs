using DecoratorPattern.Component;
using System;

namespace DecoratorPattern.ConcreteComponent
{
    class Cocoa : BeverageItem
    {
        public int CocoaPercentage { get; set; }

        public Cocoa() : base(1.75M, 30, "Cocoa")
        {
            CocoaPercentage = 15;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Cocoa percentage: {CocoaPercentage}%");
        }
    }
}
