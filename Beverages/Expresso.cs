using System;

namespace DecoratorExample.Beverages
{
    public class Expresso : IHotBeverage
    {
        public void Make()
        {
            Console.WriteLine("with high presure hot water and ground expresso beans");
        }
    }
}