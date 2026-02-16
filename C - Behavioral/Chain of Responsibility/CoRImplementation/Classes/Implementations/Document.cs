namespace CoRImplementation.Classes.Implementations
{
    public class Document
    {
        public string Title { get; set; }
        public DateTimeOffset LastTimeModified { get; set; }
        public bool ApprovedByLitigation { get; set; }
        public bool ApprovedByManager { get; set; }

        public Document(
            string title,
            DateTimeOffset lastTimeModified,
            bool approvedByLitigation,
            bool approvedByManager)
        {
            Title = title;
            LastTimeModified = lastTimeModified;
            ApprovedByLitigation = approvedByLitigation;
            ApprovedByManager = approvedByManager;
        }

    }
}
