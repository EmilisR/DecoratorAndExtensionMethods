using DecoratorPattern.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                //AddToPrice(_sugarPrice * _sugar);
            }

        }

        public void AddSugar(int amount)
        {
            if (_sugar + amount <= 5)
            {
                _sugar += amount;
                //AddToPrice(_sugarPrice * _sugar);
            }

        }

        public void RemoveSugar(int amount)
        {
            if (_sugar - amount >= 0)
            {
                _sugar -= amount;
                //AddToPrice(_sugarPrice * amount * -1);
            }
        }

        public decimal ModifyPrice(decimal price)
        {
            return price += 0.05M;
        }

        public string GetInfo()
        {
            return $"Sugar amount: {_sugar}";
        }
    }
}
