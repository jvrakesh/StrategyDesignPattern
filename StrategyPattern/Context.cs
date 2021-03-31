using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    class Context
    {
        private IStrategy _strategy;

        public Context(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void ContextInterface()
        {
            _strategy.AlgorithInterface();
        }
    }
}
