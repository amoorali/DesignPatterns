using ProxyImplementation.Classes.Contracts;

namespace ProxyImplementation.Classes.Implementations
{
    public class Document : IDocument
    {
        public string? Title { get; private set; }
        public string? Content { get; private set; }
        public int AuthorId { get; private set; }
        public DateTimeOffset LastTImeAccess { get; private set; }

        private string _fileName;

        public Document(string fileName)
        {
            _fileName = fileName;
            LoadDocument(_fileName);
        }

        private void LoadDocument(string fileName)
        {
            Console.WriteLine("Executing expensive action: loading a file from disk.");
            Thread.Sleep(1000);

            Title = "An expensive document";
            Content = "Lots and lots of content";
            AuthorId = 1;
            LastTImeAccess = DateTimeOffset.UtcNow;
        }

        public void DisplayDocument()
        {
            Console.WriteLine($"Title: {Title}, Content: {Content}");
        }

    }
}
