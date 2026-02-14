using ProxyImplementation.Classes.Contracts;

namespace ProxyImplementation.Classes.Implementations
{
    public class ProtectedDocumentProxy : IDocument
    {
        private string _fileName;
        private string _userRole;
        private Lazy<DocumentProxy> _documentProxy;

        public ProtectedDocumentProxy(string fileName, string userRole)
        {
            _fileName = fileName;
            _userRole = userRole;
            _documentProxy = new Lazy<DocumentProxy>(() => new DocumentProxy(_fileName));
        }

        public void DisplayDocument()
        {
            Console.WriteLine("Entering DisplayDocument: " +
                $"in {nameof(ProtectedDocumentProxy)}");

            if (_userRole != "Viewer")
                throw new UnauthorizedAccessException();

            _documentProxy.Value.DisplayDocument();

            Console.WriteLine("Exiting DisplayDocument: " +
                $"in {nameof(ProtectedDocumentProxy)}");
        }
    }
}
