using CoRImplementation.Classes.Contracts;
using System.ComponentModel.DataAnnotations;

namespace CoRImplementation.Classes.Implementations
{
    public class DocumentApprovedByManagerHandler : IHandler<Document>
    {
        private IHandler<Document>? _successor;

        public void Handle(Document document)
        {
            if (!document.ApprovedByManager)
            {
                throw new ValidationException(
                    new ValidationResult("Document must be approved by manager.",
                    new List<string>() { "ApprovedByManager" }), null, null);
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
