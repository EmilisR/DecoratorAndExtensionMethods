using DecoratorPattern.Component;
using System;

namespace DecoratorPattern.ConcreteComponent
{
    class Latte : IBeverageItem
    {
        public decimal Price { get; private set; }
        public int Time { get; private set; }
        public string Name { get; private set; }
        public int CoffeePercentage { get; private set; }

        public Latte()
        {
            CoffeePercentage = 60;
            Price = 2.19M;
            Time = 50;
            Name = "Coffee with milk";
        }
        public void MakeDrink()
        {
            Console.WriteLine($"Making drink: {Name}");
            Console.WriteLine($"Making time: {Time} seconds");
            Console.WriteLine($"Cocoa percentage: {CoffeePercentage}%");
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
