using DecoratorPattern.Component;
using System;

namespace DecoratorPattern.ConcreteComponent
{
    class Cocoa : IBeverageItem
    {
        public decimal Price { get; private set; }
        public int Time { get; private set; }
        public string Name { get; private set; }
        public int CocoaPercentage { get; private set; }

        public Cocoa()
        {
            CocoaPercentage = 15;
            Price = 1.75M;
            Time = 30;
            Name = "Cocoa";
        }

        public void MakeDrink()
        {
            Console.WriteLine($"Making drink: {Name}");
            Console.WriteLine($"Making time: {Time} seconds");
            Console.WriteLine($"Cocoa percentage: {CocoaPercentage}%");
            Console.WriteLine($"Total price: {Price} EUR");
        }

        public IBeverageItem GetBeverageItem()
        {
            return this;
        }

        public bool CheckRole(Type type)
        {
            return type == GetType();
        }

        public IBeverageItem GetRole(Type type)
        {
            return GetBeverageItem();
        }

        public decimal GetPrice()
        {
            return Price;
        }

        public void AddToPrice(decimal price)
        {
            Price += price;
        }
    }
}
