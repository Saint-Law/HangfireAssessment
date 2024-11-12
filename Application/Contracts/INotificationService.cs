namespace Application.Contracts;

public interface INotificationService
{
    Task SendEmail(string subject, string body, string recepient);
}
