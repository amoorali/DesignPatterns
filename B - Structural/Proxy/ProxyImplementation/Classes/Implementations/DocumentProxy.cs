using ProxyImplementation.Classes.Contracts;

namespace ProxyImplementation.Classes.Implementations
{
    public class DocumentProxy : IDocument
    {
        private string _fileName;
        private Lazy<Document> _document;

        public DocumentProxy(string fileName)
        {
            _fileName = fileName;
            _document = new Lazy<Document>(() => new Document(_fileName));
        }

        public void DisplayDocument()
        {
            Console.WriteLine($"Title: {_document.Value.Title}," +
                $" Content: {_document.Value.Content}");
        }
    }
}
