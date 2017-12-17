using DecoratorPattern.Component;
using System;

namespace DecoratorPattern.ConcreteComponent
{
    class DarkCoffee : IBeverageItem
    {
        public decimal Price { get; private set; }
        public int Time { get; private set; }
        public string Name { get; private set; }

        public DarkCoffee()
        {
            Price = 1.59M;
            Time = 45;
            Name = "Black coffee";
        }
        public void MakeDrink()
        {
            Console.WriteLine($"Making drink: {Name}");
            Console.WriteLine($"Making time: {Time} seconds");
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
