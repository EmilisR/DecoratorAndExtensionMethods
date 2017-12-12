using DecoratorPattern.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.AbstractDecorator
{
    abstract class Decorator : BeverageItem
    {
        protected BeverageItem beverageItem;

        public Decorator(BeverageItem beverageItem)
        {
            this.beverageItem = beverageItem;
        }

        public override void MakeDrink()
        {
            beverageItem.MakeDrink();
        }
    }
}
