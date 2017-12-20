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
        private List<ToppingHelper.Topping> toppings = new List<ToppingHelper.Topping>();

        public ToppingsDecorator(IBeverageItem beverageItem) : base(beverageItem, "ToppingsDecorator")
        {
            _beverageItem = beverageItem;
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
