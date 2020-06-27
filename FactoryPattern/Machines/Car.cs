using FactoryPattern.Interfaces;
using System;

namespace FactoryPattern.Machines {
    public class Car : IMachine {
        public string Name {
            get { return "car"; }
        }

        public void TurnOn() {
            Console.WriteLine("Car is starting.");
        }

        public void TurnOff() {
            Console.WriteLine("Car is stopping.");
        }
    }
}
