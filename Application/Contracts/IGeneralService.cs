namespace Application.Contracts;

public interface IGeneralService
{
    Task<bool> SendEmail(SendEmailDto model);
}
