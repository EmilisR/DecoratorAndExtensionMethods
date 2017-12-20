using DecoratorPattern.AbstractDecorator;
using DecoratorPattern.Component;
using System;

namespace DecoratorPattern.ConcreteDecorator
{
    class SugarDecorator : Decorator
    {
        private int _sugar;
        private decimal _sugarPrice;
        private IBeverageItem _beverageItem;

        public SugarDecorator(IBeverageItem beverageItem) : base(beverageItem, "SugarDecorator")
        {
            _beverageItem = beverageItem;
            _sugarPrice = 0.05M;
        }

        public void AddSugar()
        {
            if (_sugar < 5)
            {
                _sugar++;
                AddToPrice(_sugarPrice * _sugar);
            }
                
        }

        public void AddSugar(int amount)
        {
            if (_sugar + amount <= 5)
            {
                _sugar += amount;
                AddToPrice(_sugarPrice * _sugar);
            }
                
        }

        public void RemoveSugar(int amount)
        {
            if (_sugar - amount >= 0)
            {
                _sugar -= amount;
                AddToPrice(_sugarPrice * amount * -1);
            }
        }

        public override void MakeDrink()
        {
            base.MakeDrink();
            Console.WriteLine($"Sugar amount: {_sugar}");
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
