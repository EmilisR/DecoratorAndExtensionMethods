using DecoratorPattern.Component;

namespace DecoratorPattern.ConcreteComponent
{
    class DarkCoffee : BeverageItem
    {
        public DarkCoffee() : base(1.59M, 45, "Black coffee")
        {

        }
    }
}
