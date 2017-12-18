using DecoratorPattern.Extension;

namespace DecoratorPattern.ConcreteExtension
{
    class SugarExtension : IBeverageExtension
    {
        private int _sugar;
        private decimal _sugarPrice;

        public SugarExtension()
        {
            _sugarPrice = 0.05M;
        }

        public void AddSugar()
        {
            if (_sugar < 5)
            {
                _sugar++;
            }

        }

        public void AddSugar(int amount)
        {
            if (_sugar + amount <= 5)
            {
                _sugar += amount;
            }

        }

        public void RemoveSugar(int amount)
        {
            if (_sugar - amount >= 0)
            {
                _sugar -= amount;
            }
        }

        public decimal ModifyPrice(decimal price)
        {
            return price += (_sugarPrice * _sugar);
        }

        public string GetInfo()
        {
            return $"Sugar amount: {_sugar}";
        }
    }
}
