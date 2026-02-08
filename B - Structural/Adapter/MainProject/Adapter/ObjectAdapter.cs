using BusinessLayer;
using SendGrid;
using SendGrid.Helpers.Mail;

namespace MainProject.Adapter
{
    public class ObjectAdapter : IUserNotificationService
    {
        private readonly SendGridClient _client;

        public ObjectAdapter(SendGridClient client)
        {
            _client = client;
        }

        public Task NotifyUser(string userId, string message)
        {
            return _client.SendEmailAsync(new SendGridMessage());
        }
    }
}
