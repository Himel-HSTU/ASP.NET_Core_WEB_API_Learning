using Microsoft.AspNetCore.Mvc;


namespace MonitoringApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly ILogger<UsersController> _logger;

    public UsersController(ILogger<UsersController> logger)
    {
        _logger = logger;
    }
    // GET: api/<UsersController>
    [HttpGet]
    public IActionResult Get()
    {
        _logger.LogInformation("api\\users Called : Get All Users");
        throw new Exception("Something went wrong");
        //return Ok(new string[] { "user1", "user2" });
    }

    // GET api/<UsersController>/5
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        //if (id < 0 || id >100)
        //{
        //    _logger.LogWarning(@"api\users\{id} Called : Invalid Id: {id}. Id must be between 0 and 100.",id,id);
        //    return BadRequest("Invalid Id. Id must be between 0 and 100.");
        //}
        //_logger.LogInformation(@"api\users\{id} Called : Valid Id: {id}",id,id);
        //return Ok($"Valid Id: {id}");

        try
        {
            if (id<0 || id>100)
            {
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be between 0 and 100.");
            }
            _logger.LogInformation(@"api\users\{id} Called : Valid Id: {id}", id, id);
            return Ok($"Valid Id: {id}");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, @"api\users\{id} Called : Error occurred while processing request for Id: {id}", id, id);
            return BadRequest($"Error occurred while processing request for Id: {id}. {ex.Message}");
        }
    }

    //// POST api/<UsersController>
    //[HttpPost]
    //public void Post([FromBody] string value)
    //{
    //}

    //// PUT api/<UsersController>/5
    //[HttpPut("{id}")]
    //public void Put(int id, [FromBody] string value)
    //{
    //}

    //// DELETE api/<UsersController>/5
    //[HttpDelete("{id}")]
    //public void Delete(int id)
    //{
    //}
}

//Notes:::

// Today we will learn about logging in ASP.NET Core Web API. Logging is an essential part of any application, as it helps developers to track the flow of the application and identify issues. In this example, we will use the built-in logging framework provided by ASP.NET Core.
// First we need to inject the ILogger service into our UsersController. We can do this by adding a constructor that takes an ILogger<UsersController> parameter and assigns it to a private field.
// Next, we will add logging statements to our desired method. We will log a warning message if the id parameter is less than 0 or greater than 100, and an information message if the id parameter is valid. We will use the LogWarning and LogInformation methods of the ILogger interface to log these messages.

// Important Note: During Logging we will always use the structured logging approach insetad of string interpolation. Structured logging allows us to log data in a structured format, which makes it easier to query and analyze the logs later.
// _logger.LogWarning("Invalid Id: {Id}. Id must be between 0 and 100.",id); (we can use the id parameter later for querying)
// where as in string interpolation _logger.LogWarning($"Invalid Id: {Id}. Id must be between 0 and 100.") we will not be able to query the id parameter later.

// We have made "MonitoringApi.Controllers": "Warning" in appsettings.json file so that only warning log will show for this namespace. If we want to see the information log for this namespace then we can change it to "Information" or "Debug" or "Trace" level.This way we can control the unnecessary log messages and focus on the important ones