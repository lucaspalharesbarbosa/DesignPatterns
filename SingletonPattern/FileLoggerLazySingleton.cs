using SingletonPattern.Interfaces;
using System.IO;

namespace SingletonPattern {
    public class FileLoggerLazySingleton : IFileLogger {
        private readonly TextWriter _logfile;
        private const string FilePath = @"D:\logfile.txt";

        private FileLoggerLazySingleton() {
            _logfile = GetFileStream();
        }

        private TextWriter GetFileStream() {
            return TextWriter.Synchronized(File.AppendText(FilePath));
        }

        public static FileLoggerLazySingleton Instance {
            get {
                return Nested.instance;
            }
        }

        private class Nested {
            static Nested() { }

            internal static readonly FileLoggerLazySingleton instance = new FileLoggerLazySingleton();
        }

        public void WriteLineToFile(string value) {
            _logfile.WriteLine(value);
        }

        public void CloseFile() {
            _logfile.Close();
        }
    }
}
