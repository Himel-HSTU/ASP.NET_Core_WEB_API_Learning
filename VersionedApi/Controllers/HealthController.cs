using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VersionedApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ApiVersionNeutral] // This controller is not version-specific
    public class HealthController : ControllerBase
    {
        [HttpGet]
        [Route("ping")]
        public IActionResult Ping()
        {
            return Ok("Pong");
        }
    }
}

// This is different from the other controllers because it is not versioned. It is a health check controller that can be used to check the health of the API. It is not versioned because it is not part of the API contract. It is just a utility controller that can be used to check the health of the API.
