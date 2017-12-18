using DecoratorPattern.Component;

namespace DecoratorPattern.ConcreteComponent
{
    class Latte : BeverageItem
    {
        public Latte() : base(2.09M, 50, "Coffee with milk")
        {

        }
    }
}
