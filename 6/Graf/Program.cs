using System;
using System.Collections.Generic;

namespace Graf
{
    
    class Program
    {
      
        static void Main(string[] args)
        {
            mechanicsGraph next = new mechanicsGraph();

            next.AddVertex("0");
            next.AddVertex("1");
            next.AddVertex("2");
            next.AddVertex("3");
            next.AddVertex("4");
            next.AddVertex("5");
            next.AddVertex("6");
            next.AddVertex("7");
            next.AddVertex("10");
         
            next.AddEdge("0", "3", 5);
            next.AddEdge("0", "1", 5);
            next.AddEdge("0", "2", 5);
            next.AddEdge("1", "2", 5);
            next.AddEdge("2", "4", 5);

            next.AddEdge("4", "5", 5);
            next.AddEdge("4", "10", 5);
            next.AddEdge("4", "7", 5);
            next.AddEdge("5", "6", 5);

            next.BFS();

            next.DFS();
            Console.ReadLine();

        }
    }
}
