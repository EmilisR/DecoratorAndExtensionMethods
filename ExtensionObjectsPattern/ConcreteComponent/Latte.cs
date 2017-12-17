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
        public Latte(decimal price, int time, string name) : base(price, time, name)
        {
        }
    }
}
