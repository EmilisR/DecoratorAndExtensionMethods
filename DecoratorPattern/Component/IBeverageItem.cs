using System;

namespace DecoratorPattern.Component
{
    interface IBeverageItem
    {
        decimal GetPrice();
        void MakeDrink();
        void AddToPrice(decimal price);
        IBeverageItem GetBeverageItem();
        bool CheckRole(Type type);
        IBeverageItem GetRole(Type type);
    }
}
