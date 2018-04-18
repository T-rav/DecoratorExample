using System;

namespace DecoratorExample
{
    public class HotBeverageDecorator : IHotBeverage
    {
        private readonly IHotBeverage _beverage;

        public HotBeverageDecorator(IHotBeverage beverage)
        {
            _beverage = beverage;
        }

        public void Make()
        {
            Console.Write($"Making a {_beverage.GetType().Name} beverage ");
            _beverage.Make();
        }
    }
}