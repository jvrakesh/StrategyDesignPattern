using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern.SortStrategy
{
    public class SortedListContext
    {
        private ISortStrategy _sortStrategy;
        private List<string> _list = new List<string>();

        public SortedListContext()
        {

        }
        public void SetSortedListContext(ISortStrategy sortStrategy)
        {
            this._sortStrategy = sortStrategy;
        }

        public void Add(string name)
        {
            _list.Add(name);
        }

        public void sort()
        {
            _sortStrategy.sort(_list);

            foreach(string name in _list)
            {
                Console.WriteLine(" " + name);
            }
            Console.WriteLine();
        }
    }
}
