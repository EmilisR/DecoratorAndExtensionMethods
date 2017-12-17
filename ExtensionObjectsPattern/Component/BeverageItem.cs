using DecoratorPattern.Extension;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DecoratorPattern.Component
{
    abstract class BeverageItem
    {
        private Dictionary<string, IBeverageExtension> _extensions = new Dictionary<string, IBeverageExtension>();
        private decimal _price;
        private int _time;
        private string _name;

        public BeverageItem(decimal price, int time, string name)
        {
            _price = price;
            _time = time;
            _name = name;
        }

        public decimal GetPrice()
        {
            var modifiedPrice = _price;
            foreach (var extension in _extensions.Values)
            {
                modifiedPrice = extension.ModifyPrice(modifiedPrice);
            }
            return modifiedPrice;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Making drink: {_name}");
            Console.WriteLine($"Making time: {_time} seconds");
            foreach (var extension in _extensions.Values)
            {
                Console.WriteLine(extension.GetInfo());
            }
            Console.WriteLine($"Total price: {_price} EUR");
        }

        public void RegisterExtension(IBeverageExtension extension)
        {
            string extensionName = extension.GetType().FullName;
            if (!_extensions.ContainsKey(extensionName))
                _extensions.Add(extensionName, extension);
            else
                throw new ArgumentException($"Extension: {extensionName} already registered");
        }

        public void UnregisterExtension(IBeverageExtension extension)
        {
            if (_extensions.ContainsValue(extension))
                _extensions.Remove(_extensions.First(x => x.Value == extension).Key);
            else
                throw new ArgumentException($"Extension {extension.GetType().FullName} not yet registered");
        }

        public bool HasExtension(IBeverageExtension extension)
        {
            return _extensions.ContainsValue(extension);
        }
    }
}
