using SingletonPattern.Interfaces;
using System;
using System.Collections.Generic;
using Unity;

namespace SingletonPattern.Container {
    public class UnityDependencyResolver {
        private static readonly IUnityContainer _container;

        static UnityDependencyResolver() {
            _container = new UnityContainer();

            IoC.Initialize(_container);
        }

        public void EnsureDependenciesRegistered() {
            _container.RegisterType<IFileLoggerFactory, LazySingletonFileLoggerFactory>();
        }

        public IUnityContainer Container {
            get {
                return _container;
            }
        }
    }
}
