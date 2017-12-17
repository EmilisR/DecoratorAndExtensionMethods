using DecoratorPattern.Component;
using System;

namespace DecoratorPattern.AbstractDecorator
{
    abstract class Decorator : IBeverageItem
    {
        protected IBeverageItem beverageItem;

        public Decorator(IBeverageItem beverageItem)
        {
            this.beverageItem = beverageItem;
        }

        public virtual void MakeDrink()
        {
            beverageItem.MakeDrink();
        }

        public virtual IBeverageItem GetBeverageItem()
        {
            return beverageItem.GetBeverageItem();
        }

        public virtual bool CheckRole(Type type)
        {
            return beverageItem.CheckRole(type);
        }

        public virtual IBeverageItem GetRole(Type type)
        {
            return beverageItem.GetRole(type);
        }

        public virtual decimal GetPrice()
        {
            return beverageItem.GetPrice();
        }

        public virtual void AddToPrice(decimal price)
        {
            beverageItem.AddToPrice(price);
        }
    }
}
