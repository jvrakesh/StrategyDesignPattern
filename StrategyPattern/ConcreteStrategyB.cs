using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class ConcreteStrategyB : IStrategy
    {
        public void AlgorithInterface()
        {
            Console.WriteLine("Called Concrete Strategy B Algorithm");
        }
    }
}
