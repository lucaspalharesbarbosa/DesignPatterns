using SingletonPattern.Container;
using SingletonPattern.Interfaces;
using System;
using Unity;

namespace SingletonPattern {
    class Program {
        private static UnityDependencyResolver _dependencyResolver;
        private static INumberWriter _numberWriter;

        public static void Main(string[] args) {
            RegisterTypes();

            _numberWriter = _dependencyResolver.Container.Resolve<INumberWriter>();
            _numberWriter.WriteNumbersToFile(100);

            Console.WriteLine("File write done.");
            Console.ReadLine();
        }

        private static void RegisterTypes() {
            _dependencyResolver = new UnityDependencyResolver();
            _dependencyResolver.EnsureDependenciesRegistered();
            _dependencyResolver.Container.RegisterType<INumberWriter, AsyncNumberWriter>();
        }
    }
}
