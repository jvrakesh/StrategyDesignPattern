using StrategyPattern.SortStrategy;
using System;
//This structural code demonstrates the Strategy pattern which encapsulates 
//functionality in the form of an object. 
//This allows clients to dynamically change algorithmic strategies.

//https://www.dofactory.com/net/strategy-design-pattern 

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basic 

            Context context;
            context = new Context(new ConcreteStrategyA());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyB());
            context.ContextInterface();

            context = new Context(new ConcreteStrategyC());
            context.ContextInterface();

            Console.ReadLine();


            //Real world scenario

            //Add records to the list
            SortedListContext sortListContext = new SortedListContext();
            sortListContext.Add("Sam");
            sortListContext.Add("Tom");
            sortListContext.Add("Jim");
            sortListContext.Add("John");
            sortListContext.Add("Amy");


            sortListContext.SetSortedListContext(new MergeSort());
            sortListContext.sort();

            //different sort Type

            sortListContext.SetSortedListContext(new QuickSort());
            sortListContext.sort();


            //different

            sortListContext.SetSortedListContext(new ShellSort());
            sortListContext.sort();

            Console.ReadLine();
        }
    }
}
