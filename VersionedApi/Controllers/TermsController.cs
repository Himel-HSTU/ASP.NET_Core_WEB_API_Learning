using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VersionedApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [ApiVersionNeutral] // This controller is not version-specific
    public class TermsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetTerms()
        {
            var terms = $"These are the terms of service for our API. By using this API, you agree to comply with these terms.";
            return Ok(terms);
        }
    }
}
