

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly IGeneralService _generalService;

        public NotificationsController(IGeneralService generalService)
        {
            _generalService = generalService;
        }

        [HttpPost]
        public async Task<ActionResult> SendEmail(SendEmailDto request)
        {
            var response = await _generalService.SendEmail(request);
            if (response)
                return Ok("Email Sent");
            return BadRequest("Unable to send email");

        }

    }
}
