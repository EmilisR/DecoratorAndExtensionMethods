using System;

namespace DecoratorPattern.Extension
{
    interface IBeverageExtension
    {
        decimal ModifyPrice(decimal price);
        string GetInfo();
    }
}
