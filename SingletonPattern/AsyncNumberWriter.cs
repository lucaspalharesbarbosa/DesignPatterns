using SingletonPattern.Interfaces;
using System;
using System.Threading.Tasks;

namespace SingletonPattern {
    public class AsyncNumberWriter : INumberWriter {
        private readonly IFileLoggerFactory _fileLoggerFactory;

        public AsyncNumberWriter(IFileLoggerFactory fileLoggerFactory) {
            _fileLoggerFactory = fileLoggerFactory;
        }

        public void WriteNumbersToFile(int max) {
            IFileLogger myLogger = null;

            Action<int> logToFile = i => {
                myLogger = _fileLoggerFactory.Create();
                myLogger.WriteLineToFile("Ready for next number...");
                myLogger.WriteLineToFile("Logged number: " + i);
            };

            Parallel.For(0, max, logToFile);

            myLogger.CloseFile();
        }
    }
}
