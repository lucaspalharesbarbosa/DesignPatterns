using CreationalsPatterns.Builders;
using System;

namespace CreationalsPatterns {
    class Program {
        static void Main(string[] args) {
            var graphCreator = new GraphCreator(new SpecialGraphBuilder());

            graphCreator.CreateGraph();

            var graph = graphCreator.GetClassyGraph();

            Console.WriteLine(graph);

            Console.ReadKey();
        }
    }
}
