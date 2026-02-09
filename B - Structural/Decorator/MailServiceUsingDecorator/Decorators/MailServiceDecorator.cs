using MailServiceUsingDecorator.Contracts;

namespace MailServiceUsingDecorator.Decorators
{
    public class MailServiceDecorator : IMailService
    {
        private readonly IMailService _mailService;

        public MailServiceDecorator(IMailService mailService)
        {
            _mailService = mailService;
        }

        public virtual bool SendMail(string message)
        {
            return _mailService.SendMail(message);
        }
    }
}
