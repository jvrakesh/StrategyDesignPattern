using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class ConcreteStrategyA : IStrategy
    {
        public void AlgorithInterface()
        {
            Console.WriteLine(" Called the ConcreteStrategyA.AlgorithInterface");
        }
    }
}
