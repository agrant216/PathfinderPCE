using Microsoft.AspNetCore.Mvc;
using PathfinderData.Core;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PathfinderPCE.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlayerCharacterController : ControllerBase
    {
        // GET: api/<PlayerCharacterController>/new
        [HttpGet("new")]
        public PlayerCharacter GetNewCharacter()
        {
            return new PlayerCharacter();
        }

        // GET: api/<PlayerCharacterController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PlayerCharacterController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PlayerCharacterController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PlayerCharacterController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PlayerCharacterController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
