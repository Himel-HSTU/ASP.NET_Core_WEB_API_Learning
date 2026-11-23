using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace GettingStartedWebAPI.Controllers;
    
[Route("api/[controller]")]
[ApiController]
[Authorize]
public class UsersController : ControllerBase
{
    private readonly IConfiguration _config;
    public UsersController(IConfiguration config)
    {
        _config = config;
    }

    // GET: api/<UsersController>
    [HttpGet]
    public IEnumerable<string> Get()
    {
        List<string> users = new List<string>();
        for (int i = 0; i < Random.Shared.Next(3, 10); i++)
        {
            users.Add($"User {i}");
        }
        return users; 
    }

    // GET api/<UsersController>/5
    [HttpGet("{id}")]
    [Authorize(Policy = "MustHaveEmployeeId")] 
    public string Get(int id)
    {
        return _config.GetConnectionString("Default");
    }
    [HttpGet("{test}/{id}")] // 
    [Authorize(Policy = "MustBeMaleOrFemale")]
    public string Get([FromRoute] int id, [FromBody] string value)
    {
        return $"This is From our Dusto Get Request,You Have to be Male or Female  {value}";
    }
    // POST api/<UsersController>
    [HttpPost]
    public string Post([FromBody] string value)
    {
        return $"Posted: {value}";
    }

    // PUT api/<UsersController>/5
    [HttpPut("{id}")]
    public string Put(int id, [FromBody] string value)
    {
        return $"Updated: {value}";
    }

    // DELETE api/<UsersController>/5
    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return $"Deleted: {id}";
    }
}
