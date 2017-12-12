using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Helper
{
    public class ToppingHelper
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
