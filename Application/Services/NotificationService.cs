

namespace Application.Services
{
    public class NotificationService : INotificationService
    {
        private readonly ILogger<NotificationService> _logger;
        private readonly HttpClient _httpClient;

        public NotificationService(ILogger<NotificationService> logger)
        {
            _logger = logger;
            _httpClient = new HttpClient();
        }

        public async Task SendEmail(string subject, string body, string recepient)
        {
            try
            {
                var data = new { subject, body, recepient };
                var baseUrl = "https://sampleapi/api/Email";
                var requestContent = new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");
                await _httpClient.PostAsync(baseUrl, requestContent);
            }
            catch (Exception ex) 
            {
                _logger.LogError(ex, ex.Message);
            }
        }


    }
}
