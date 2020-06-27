using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace PrototypePattern {
    public class DocumentReader : ICloneable {
        private string _pageTitle;
        private int _headerCount;
        private string _bodyContent;

        public DocumentReader(Uri uri) {
            var httpClient = new HttpClient();

            Task<string> contents = httpClient.GetStringAsync(uri);
            string stringContents = contents.Result;

            Analyse(stringContents);
        }

        private void Analyse(string stringContents) {
            _pageTitle = "Homepage";
            _headerCount = 2;
            _bodyContent = "Welcome to my homepage";
        }

        public void PrintPageData() {
            Console.WriteLine("Page title: {0}, header count: {1}, body: {2}", _pageTitle, _headerCount, _bodyContent);
        }

        public object Clone() {
            return MemberwiseClone();
        }
    }
}
