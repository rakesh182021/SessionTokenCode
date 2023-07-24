using Microsoft.AspNetCore.Mvc;
using SessionTokenApi.Model;
using System.Threading.Tasks;

namespace SessionTokenApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SessionTokenController : ControllerBase
    {
        private readonly SessionTokenService _sessionTokenService;

        public SessionTokenController(SessionTokenService sessionTokenService)
        {
            _sessionTokenService = sessionTokenService;
        }

        [HttpPost("getSessionToken")]
        public async Task<string> Get([FromBody] SessionTokenRequest request) => await _sessionTokenService.GetSessionToken(request);
    }
}
