using FactoryPattern.Interfaces;
using System;

namespace FactoryPattern.Machines {
    public class Robot : IMachine {
        public string Name {
            get { return "robot"; }
        }

        public void TurnOn() {
            Console.WriteLine("Robot is starting.");
        }

        public void TurnOff() {
            Console.WriteLine("Robot is stopping.");
        }
    }
}
