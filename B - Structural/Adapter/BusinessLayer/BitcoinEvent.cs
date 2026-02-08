namespace BusinessLayer
{
    public class BitcoinEvent
    {

        private readonly IUserNotificationService _userNotificationService;

        public BitcoinEvent(IUserNotificationService userNotificationService)
        {
            _userNotificationService = userNotificationService;
        }

        public Task Execute()
        {
            return _userNotificationService.NotifyUser("", "");
        }
    }
}
