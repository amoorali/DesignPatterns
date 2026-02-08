using SendGrid;
using SendGrid.Helpers.Mail;

namespace BusinessLayer
{
    public class EmployeeFiredEvent
    {
        private readonly IUserNotificationService _userNotificationService;

        public EmployeeFiredEvent(IUserNotificationService userNotificationService)
        {
            _userNotificationService = userNotificationService;
        }

        public Task Execute()
        {
            return _userNotificationService.NotifyUser("", "");
        }
    }
}
