using SBP.Domain;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using SBP.Domain.DTO.Student;
using SBP.Domain.Interface.Repository;

namespace SBP.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _repository;

        public StudentController(IStudentRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Busca os estudantes cadastrados",
                          Description = "Busca os estudantes cadastrados",
                          OperationId = "Get",
                          Tags = null)]
        [ProducesResponseType(typeof(List<StudentDTO>), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public IActionResult Get()
        {
            return Ok(_repository.GetAll());
        }

        [HttpGet("{id}")]
        [SwaggerOperation(Summary = "Busca um estudante",
                          Description = "Busca um estudante por ID",
                          OperationId = "GetById",
                          Tags = null)]
        [ProducesResponseType(typeof(StudentDTO), 200)]
        [ProducesResponseType(404)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public IActionResult Get(int id)
        {
            return Ok(_repository.GetById(id));
        }

        [HttpPost]
        [SwaggerOperation(Summary = "Insere um novo estudante",
                        Description = "Insere um novo estudante",
                        OperationId = "Insert",
                        Tags = null)]
        [ProducesResponseType(typeof(Student), 201)]
        [ProducesResponseType(400)]
        [ProducesResponseType(500)]
        public IActionResult Post(StudentDTO studentDTO)
        {
            return StatusCode(201, _repository.Insert(studentDTO));
        }
    }
}
