using DecoratorPattern.AbstractDecorator;
using DecoratorPattern.Component;
using DecoratorPattern.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteDecorator
{
    class ToppingsDecorator : Decorator
    {
        private IBeverageItem _beverageItem;
        private IBeverageItem _baseItem;
        private List<ToppingHelper.Topping> toppings = new List<ToppingHelper.Topping>();

        public ToppingsDecorator(IBeverageItem beverageItem) : base(beverageItem)
        {
            _beverageItem = beverageItem;
            _baseItem = GetBeverageItem();
        }

        public void AddTopping(params ToppingHelper.Topping[] topping)
        {
            toppings.AddRange(topping);
            AddToPrice(topping.Select(x => ToppingHelper.ToppingPrices[x]).Sum());
        }

        public override void MakeDrink()
        {
            base.MakeDrink();

            if (toppings.Count > 0)
            {
                var writedToppings = 0;
                Console.Write($"Selected toppings: ");
                foreach (var item in toppings)
                {
                    Console.Write(item.GetAttribute<DescriptionAttribute>().Description);
                    if (writedToppings < toppings.Count - 1)
                        Console.Write(", ");
                    writedToppings++;
                }
            }
        }

        public override IBeverageItem GetBeverageItem()
        {
            if (_beverageItem.GetType().Namespace == "DecoratorPattern.ConcreteComponent")
            {
                return _beverageItem;
            }
            else
                return base.GetBeverageItem();
        }

        public override bool CheckRole(Type type)
        {
            if (type == this.GetType())
                return true;
            else
                return _beverageItem.CheckRole(type);
        }

        public override IBeverageItem GetRole(Type type)
        {
            if (type == this.GetType())
                return this;
            else
                return base.GetRole(type);
        }

        public override decimal GetPrice()
        {
            return base.GetPrice();
        }

        public override void AddToPrice(decimal price)
        {
            base.AddToPrice(price);
        }
    }
}
