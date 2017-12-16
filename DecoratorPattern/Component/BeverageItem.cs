using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Component
{
    abstract class BeverageItem
    {
        private decimal _price;
        private int _time;
        private string _name;

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }
        public int Time
        {
            get { return _time; }
            set { _time = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public abstract void MakeDrink();
        public abstract BeverageItem GetBeverageItem();
        public abstract bool CheckRole(Type type);
        public abstract BeverageItem GetRole(Type type);
    }
}
