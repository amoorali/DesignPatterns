using CoRImplementation.Classes.Contracts;
using System.ComponentModel.DataAnnotations;

namespace CoRImplementation.Classes.Implementations
{
    public class DocumentLastModifiedHandler : IHandler<Document>
    {
        private IHandler<Document>? _successor;

        public void Handle(Document document)
        {
            if (document.LastTimeModified < DateTime.UtcNow.AddDays(-30))
            {
                throw new ValidationException(
                    new ValidationResult("Document must be modified in the last 30 days.",
                    new List<string>() { "LastModified" }), null, null);
            }

            _successor?.Handle(document);
        }

        public IHandler<Document> SetSuccessor(IHandler<Document> successor)
        {
            _successor = successor;

            return _successor;
        }
    }
}
