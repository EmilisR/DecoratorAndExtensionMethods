using DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteComponent
{
    class Latte : BeverageItem
    {
        private int _coffeePercentage;

        public Latte(int coffeePercentage, decimal price, int time, string name)
        {
            this._coffeePercentage = coffeePercentage;
            this.Price = price;
            this.Time = time;
            this.Name = name;
        }
        public override void MakeDrink()
        {
            Console.WriteLine($"Making drink: {this.Name}");
            Console.WriteLine($"Making time: {this.Time} seconds");
            Console.WriteLine($"Cocoa percentage: {this._coffeePercentage}%");
            Console.WriteLine($"Total price: {this.Price} EUR");
        }

        public override BeverageItem GetBeverageItem()
        {
            return this;
        }

        public override bool CheckRole(Type type)
        {
            return type == this.GetType();
        }

        public override BeverageItem GetRole(Type type)
        {
            return this;
        }
    }
}
