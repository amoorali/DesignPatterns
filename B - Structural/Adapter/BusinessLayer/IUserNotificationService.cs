namespace BusinessLayer
{
    public interface IUserNotificationService
    {
        Task NotifyUser(string userId, string message);
    }
}
