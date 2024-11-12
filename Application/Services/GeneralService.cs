namespace Application.Services;

public class GeneralService : IGeneralService
{
    private readonly INotificationService _notificationService;
    private readonly ILogger<GeneralService> _logger;

    public GeneralService(INotificationService notificationService, ILogger<GeneralService> logger)
    {
        _notificationService = notificationService;
        _logger = logger;
    }

    public async Task<bool> SendEmail(SendEmailDto model)
    {
        try
        {
            //schedules the job with hangfire
            BackgroundJob.Enqueue(() => _notificationService.SendEmail(model.Title, model.Body, model.EmailAddress));
            
            return true;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, ex.Message);
            return false;
        }
    }

}
