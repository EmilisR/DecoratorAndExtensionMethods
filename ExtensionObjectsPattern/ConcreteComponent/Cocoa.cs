using DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteComponent
{
    class Cocoa : BeverageItem
    {
        public int CocoaPercentage { get; set; }

        public Cocoa() : base(1.75M, 30, "Cocoa")
        {
            CocoaPercentage = 15;
        }
    }
}
