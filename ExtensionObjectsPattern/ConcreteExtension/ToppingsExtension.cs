using DecoratorPattern.Extension;
using DecoratorPattern.Helper;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace DecoratorPattern.ConcreteExtension
{
    class ToppingsExtension : IBeverageExtension
    {
        private List<ToppingHelper.Topping> toppings = new List<ToppingHelper.Topping>();

        public void AddTopping(params ToppingHelper.Topping[] topping)
        {
            toppings.AddRange(topping);
        }

        public string GetInfo()
        {
            var sb = new StringBuilder();

            if (toppings.Count > 0)
            {
                var writedToppings = 0;
                sb.Append($"Selected toppings: ");
                foreach (var item in toppings)
                {
                    sb.Append(item.GetAttribute<DescriptionAttribute>().Description);
                    if (writedToppings < toppings.Count - 1)
                        sb.Append(", ");
                    writedToppings++;
                }
            }

            return sb.ToString();
        }

        public decimal ModifyPrice(decimal price)
        {
            return price += toppings.Select(x => ToppingHelper.ToppingPrices[x]).Sum();
        }
    }
}
