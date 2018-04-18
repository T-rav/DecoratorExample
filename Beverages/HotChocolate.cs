using System;

namespace DecoratorExample.Beverages
{
    public class HotChocolate : IHotBeverage
    {
        public void Make()
        {
            Console.WriteLine("with hot water, hot chocolate mix and milk");
        }
    }
}
