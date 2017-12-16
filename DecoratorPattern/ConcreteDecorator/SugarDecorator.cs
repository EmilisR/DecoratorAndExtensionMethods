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
        private BeverageItem _baseItem;

        public SugarDecorator(BeverageItem beverageItem, decimal sugarPrice) : base(beverageItem)
        {
            _beverageItem = beverageItem;
            _baseItem = GetBeverageItem();
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

        private void AddSugarPrice()
        {
            _baseItem.Price += _sugarPrice * _sugar;
        }

        public override void MakeDrink()
        {
            AddSugarPrice();
            base.MakeDrink();

            Console.WriteLine($"Sugar amount: {_sugar}");
        }

        public override BeverageItem GetBeverageItem()
        {
            if (this.beverageItem.GetType().Namespace == "DecoratorPattern.ConcreteComponent")
            {
                return this.beverageItem;
            }
            else
                return base.GetBeverageItem();
        }

        public override bool CheckRole(Type type)
        {
            if (type == this.GetType())
                return true;
            else
                return _beverageItem.CheckRole(type);
        }

        public override BeverageItem GetRole(Type type)
        {
            if (type == this.GetType())
                return this;
            else
                return base.GetRole(type);
        }
    }
}
