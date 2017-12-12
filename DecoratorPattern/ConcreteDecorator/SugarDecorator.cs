using DecoratorPattern.AbstractDecorator;
using DecoratorPattern.Component;
using System;

namespace DecoratorPattern.ConcreteDecorator
{
    class SugarDecorator : Decorator
    {
        private int _sugar;
        private decimal _sugarPrice;
        private BeverageItem _beverageItem;

        public SugarDecorator(BeverageItem beverageItem, decimal sugarPrice) : base(beverageItem)
        {
            _beverageItem = beverageItem;
            _sugarPrice = sugarPrice;
        }

        public void AddSugar()
        {
            if (_sugar < 5)
                _sugar++;
        }

        public void AddSugar(int amount)
        {
            if (_sugar + amount <= 5)
                _sugar += amount;
        }

        public void RemoveSugar()
        {
            if (_sugar > 0)
                _sugar--;
        }

        public void RemoveSugar(int amount)
        {
            if (_sugar - amount >= 0)
                _sugar -= amount;
        }

        public void NoSugar()
        {
            _sugar = 0;
        }

        public void FullSugar()
        {
            _sugar = 5;
        }

        public void AddSugarPrice()
        {
            _beverageItem.Price += _sugarPrice * _sugar;
        }

        public override void MakeDrink()
        {
            AddSugarPrice();
            base.MakeDrink();

            Console.WriteLine($"Sugar amount: {_sugar}");
        }
    }
}
