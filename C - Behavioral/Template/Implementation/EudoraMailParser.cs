namespace Implementation
{
    public class EudoraMailParser : MailParser
    {
        public override void FindServer()
        {
            Console.WriteLine("Finding Eudora mail server through a custom algorithm...");
        }

        public override void AuthenticateToServer()
        {
            Console.WriteLine("Connecting to Eudora");
        }
    }
}
