using SingletonPattern.Interfaces;

namespace SingletonPattern {
    public class LazySingletonFileLoggerFactory : IFileLoggerFactory {
        public IFileLogger Create() {
            return FileLoggerLazySingleton.Instance;
        }
    }
}
