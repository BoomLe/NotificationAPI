using NotificationAPI.Models;

namespace NotificationAPI.Services.IServices
{
    public interface INotificationService
    {
        Task<ResponseModel> SendNotification(NotificationModel notificationModel);

    }
}
