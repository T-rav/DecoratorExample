using System;

namespace DecoratorExample.Beverages
{
    public class Tea : IHotBeverage
    {
        public void Make()
        {
            Console.Write("with boiling water and a tea bag");
        }
    }
}