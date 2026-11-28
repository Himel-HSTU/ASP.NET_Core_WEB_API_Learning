using Microsoft.AspNetCore.Mvc;
using ProtectingApi.Models;


namespace ProtectingApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "user1", "user2" };
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UsersController>
        [HttpPost]
        public IActionResult Post([FromBody] UserModel user)
        {
            // This ModelSate.IsValid property checks if the model passed to the action method is valid based on the data annotations defined in the UserModel class.Ex. [Required], [Range], [MinLength], [MaxLength], [EmailAddress], [Phone], and [Url] attributes.
            if (ModelState.IsValid) 
            {
                
                return Ok("The Model Was Validated Successfully");
            }
            return BadRequest(ModelState);
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UserModel userModel)
        {
            if (ModelState.IsValid)
            {
                // Process the valid user data
                return Ok();
            }
            return BadRequest(ModelState);
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
