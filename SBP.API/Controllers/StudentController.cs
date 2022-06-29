using Microsoft.AspNetCore.Mvc;
using SBP.Domain;
using Swashbuckle.AspNetCore.Annotations;

namespace SBP.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        [SwaggerOperation(Summary = "Busca os estudantes cadastrados",
                          Description = "Busca os estudantes cadastrados",
                          OperationId = "GET",                         
                          Tags = null)]
        [ProducesResponseType(typeof(List<Student>), 200)]
        [ProducesResponseType(typeof(IDictionary<string, string>), 400)]
        [ProducesResponseType(500)]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<StudentController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<StudentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
