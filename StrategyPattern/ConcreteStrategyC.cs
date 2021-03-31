using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class ConcreteStrategyC : IStrategy
    {
        public void AlgorithInterface()
        {
            Console.WriteLine("Called Concrete Strategy C Algorithm");
        }
    }
}
