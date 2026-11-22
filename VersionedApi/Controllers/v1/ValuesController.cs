using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace VersionedApi.Controllers.v1
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    [ApiVersion("1.0")]
    [ApiVersion("2.0", Deprecated = true)] //  api-deprecated-versions: 2.0 , api-supported-versions: 1.0,3.0 only for this Values Controller not the whole API Version, indicating users to avoid using this version
    [ApiVersion("3.0")]
    public class ValuesController : ControllerBase
    {
        // GET: api/<ValuesController>
        [HttpGet]
        [MapToApiVersion("1.0")]
        public IEnumerable<string> Getv1()
        {   
            return new string[] { "value1", "value2","From Version 1.0" };
        }


        [HttpGet]
        [MapToApiVersion("2.0")] 
        public IEnumerable<string> Getv2()
        {
            return new string[] { "value1", "value2","From Version 2.0" };
        }

        [HttpGet]
        [MapToApiVersion("3.0")]
        public IEnumerable<string> Getv3()
        {
            return new string[] { "value1", "value2", "From Version 3.0" };
        }

        //We can have multiple versions of the same controller, but we need to specify which version each action belongs to using the [MapToApiVersion] attribute.
        //which is not recomended, instead we should create a new controller and arragnge different folder for each version and specify the version using the [ApiVersion("x.y")] attribute on the controller class.

        // GET api/<ValuesController>/5
        //[HttpGet("{id}")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST api/<ValuesController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<ValuesController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<ValuesController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
