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
        private IBeverageItem _baseItem;

        public SugarDecorator(IBeverageItem beverageItem) : base(beverageItem)
        {
            _beverageItem = beverageItem;
            _baseItem = GetBeverageItem();
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

        public override IBeverageItem GetBeverageItem()
        {
            if (beverageItem.GetType().Namespace == "DecoratorPattern.ConcreteComponent")
            {
                return beverageItem;
            }
            else
                return base.GetBeverageItem();
        }

        public override bool CheckRole(Type type)
        {
            if (type == GetType())
                return true;
            else
                return _beverageItem.CheckRole(type);
        }

        public override IBeverageItem GetRole(Type type)
        {
            if (type == GetType())
                return this;
            else
                return base.GetRole(type);
        }

        public override void AddToPrice(decimal price)
        {
            base.AddToPrice(price);
        }
    }
}
