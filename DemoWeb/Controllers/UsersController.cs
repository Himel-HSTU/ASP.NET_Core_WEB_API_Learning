using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DemoWeb.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    // GET: api/<UsersController>
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1 from DemoWeb", "value2 from DemoWeb" };
    }

    // GET api/<UsersController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return $"value:{id} from DemoWeb";
    }

    // POST api/<UsersController>
    [HttpPost]
    public string Post([FromBody] string value)
    {
        return $"Posted: {value} from DemoWeb";
    }

    // PUT api/<UsersController>/5
    [HttpPut("{id}")]
    public string Put(int id, [FromBody] string value)
    {
        return $"Updated: {value} from DemoWeb";
    }

    // DELETE api/<UsersController>/5
    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return $"Deleted: {id} from DemoWeb";
    }
}
