using DecoratorPattern.AbstractDecorator;
using System;

namespace DecoratorPattern.Component
{
    interface IBeverageItem
    {
        decimal GetPrice();
        void MakeDrink();
        void AddToPrice(decimal price);
    }
}
