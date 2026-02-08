using BusinessLayer;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace MainProject.Adapter
{
    public class ClassAdapter : SendGridClient, IUserNotificationService
    {
        public ClassAdapter(SendGridClientOptions options) : base(options)
        {
        }

        public Task NotifyUser(string userId, string message)
        {
            return SendEmailAsync(new SendGridMessage());
        }
    }
}
