using FactoryPattern.Interfaces;
using System;

namespace FactoryPattern {
    class Program {
        static void Main(string[] args) {
            string description = args[0];

            IMachine machine = new MachineFactory().CreateInstance(description);

            machine.TurnOn();
            machine.TurnOff();

            Console.ReadKey();
        }
    }
}
