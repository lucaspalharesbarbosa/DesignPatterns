using System;

namespace PrototypePattern {
    class Program {
        static void Main(string[] args) {
            var reader = new DocumentReader(new Uri("http://bbc.co.uk"));
            reader.PrintPageData();

            var readerClone = reader.Clone() as DocumentReader;
            readerClone.PrintPageData();

            Console.ReadKey();
        }
    }
}
