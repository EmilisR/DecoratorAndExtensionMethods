using DecoratorPattern.Component;
using System;

namespace DecoratorPattern.AbstractDecorator
{
    abstract class Decorator : IBeverageItem
    {
        protected IBeverageItem beverageItem;
        private string roleName;
        public Decorator(IBeverageItem beverageItem, string roleName)
        {
            this.beverageItem = beverageItem;
            this.roleName = roleName;
        }

        public virtual void MakeDrink()
        {
            beverageItem.MakeDrink();
        }


        public bool CheckRole(string role)
        {
            return GetRole(role) != null;
        }

        public IBeverageItem GetBase()
        {
            if (beverageItem is Decorator decorator)
                return decorator.GetBase();
            return beverageItem;
        }

        public Decorator GetRole(string role)
        {
            if (roleName.Equals(role))
                return this;
            if (beverageItem is Decorator decorator)
                return decorator.GetRole(role);
            return null;
        }

        public IBeverageItem RemoveRole(string role)
        {
            if (roleName == role)
                return beverageItem;
            if (beverageItem is Decorator decorator)
            {
                if (decorator.roleName == role)
                {
                    beverageItem = decorator.beverageItem;
                    return this;
                }
                decorator.RemoveRole(role);
            }
            return this;
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
