using System.Collections.Generic;
using System.ComponentModel;

namespace DecoratorPattern.Helper
{
    public static class ToppingHelper
    {
        public static Dictionary<Topping, decimal> ToppingPrices = new Dictionary<Topping, decimal>()
        {
            { Topping.Caramel, 0.20M },
            { Topping.Chocolate, 0.15M },
            { Topping.Cinamon, 0.10M },
            { Topping.Cream, 0.25M },
        };

        public enum Topping
        {
            [Description("Caramel")]
            Caramel,
            [Description("Chocolate")]
            Chocolate,
            [Description("Cinamon")]
            Cinamon,
            [Description("Cream")]
            Cream
        }
    }

    
}
