using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public interface ISortStrategy
    {
        public void sort(List<string> list);
    }
}
