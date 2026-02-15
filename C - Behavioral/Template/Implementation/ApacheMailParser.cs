namespace Implementation
{
    public class ApacheMailParser : MailParser
    {

        public override void AuthenticateToServer()
        {
            Console.WriteLine("Connecting to Apache");
        }
    }
}
