using MailServiceUsingDecorator.Contracts;

namespace MailServiceUsingDecorator.Decorators
{
    public class MessageDatabaseDecorator : MailServiceDecorator
    {
        public List<string> SentMessages { get; private set; } = new List<string>();

        public MessageDatabaseDecorator(IMailService mailService)
            : base(mailService)
        {
        }

        public override bool SendMail(string message)
        {
            if (base.SendMail(message))
            {
                SentMessages.Add(message);

                return true;
            }

            return false;
        }
    }
}
