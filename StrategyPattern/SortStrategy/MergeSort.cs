using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.SortStrategy
{
    public class MergeSort : ISortStrategy
    {
        public void sort(List<string> list)
        {
            //implement MergeSort
            Console.WriteLine("Merge Sort");
        }
    }
}
