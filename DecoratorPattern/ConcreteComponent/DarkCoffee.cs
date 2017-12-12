using DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteComponent
{
    class DarkCoffee : BeverageItem
    {
        private bool _isBeans;

        public DarkCoffee(bool isBeans, decimal price, int time, string name)
        {
            this._isBeans = isBeans;
            this.Price = price;
            this.Time = time;
            this.Name = name;
        }
        public override void MakeDrink()
        {
            var type = this._isBeans ? "Beans" : "Ground";
            Console.WriteLine($"Making drink: {this.Name}");
            Console.WriteLine($"Making time: {this.Time} seconds");
            Console.WriteLine($"Coffee type: {type}");
            Console.WriteLine($"Total price: {this.Price} EUR");
        }
    }
}
