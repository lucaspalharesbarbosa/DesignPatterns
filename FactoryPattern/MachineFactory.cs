using FactoryPattern.Interfaces;
using FactoryPattern.Machines;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace FactoryPattern {
    public class MachineFactory {
        Dictionary<string, Type> machines;

        public MachineFactory() {
            LoadTypesICanReturn();
        }

        private void LoadTypesICanReturn() {
            machines = new Dictionary<string, Type>();

            Type[] typesInThisAssembly = Assembly.GetExecutingAssembly().GetTypes();

            foreach (Type type in typesInThisAssembly) {
                var interfaceType = type.GetInterface(typeof(IMachine).ToString());

                if (interfaceType != null) {
                    machines.Add(type.Name.ToLower(), type);
                }
            }
        }

        public IMachine CreateInstance(string description) {
            Type type = GetTypeToCreate(description);

            if (type == null)
                return new UnknownMachine();

            return Activator.CreateInstance(type) as IMachine;
        }

        private Type GetTypeToCreate(string machineName) {
            foreach (var machine in machines) {
                if (machine.Key.Contains(machineName)) {
                    return machines[machine.Key];
                }
            }

            return null;
        }
    }
}
