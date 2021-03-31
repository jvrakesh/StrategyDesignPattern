using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.SortStrategy
{
    public class QuickSort : ISortStrategy
    {
        public void sort(List<string> list)
        {
            //implement how this need to be sorted
            list.Sort();
            Console.WriteLine("Quick Sort");
        }
    }
}
