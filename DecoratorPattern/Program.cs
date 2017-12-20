using DecoratorPattern.ConcreteComponent;
using DecoratorPattern.ConcreteDecorator;
using System;
using DecoratorPattern.Helper;
using DecoratorPattern.AbstractDecorator;
using DecoratorPattern.Component;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Decorator decorator = new ToppingsDecorator(new SugarDecorator(new Cocoa()));
            IBeverageItem baseItem = null;
            var removed = decorator.RemoveRole("ToppingsDecorator");
            if (removed is Decorator)
                decorator = (Decorator)removed;
            else if (removed is IBeverageItem)
                baseItem = decorator.RemoveRole("ToppingsDecorator");

            removed = decorator.RemoveRole("SugarDecorator");
            if (removed is Decorator)
                decorator = (Decorator)removed;
            else if (removed is IBeverageItem)
                baseItem = decorator.RemoveRole("SugarDecorator");


            if (baseItem == null && decorator.CheckRole("SugarDecorator"))
            {
                var item = (SugarDecorator)decorator.GetRole("SugarDecorator");
                item.AddSugar(3);
            }

            if (baseItem == null && decorator.CheckRole("ToppingsDecorator"))
            {
                ((ToppingsDecorator)decorator).AddTopping(new ToppingHelper.Topping[]
                {
                    ToppingHelper.Topping.Cream,
                    ToppingHelper.Topping.Chocolate
                });
            }
            if (baseItem != null)
                baseItem.MakeDrink();
            else
                decorator.MakeDrink();
            Console.ReadKey();
        }
    }
}
