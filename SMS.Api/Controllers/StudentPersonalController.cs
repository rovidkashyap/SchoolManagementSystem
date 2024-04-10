using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMS.Application.Features.Students.Commands.StudentCommands;
using SMS.Application.Features.Students.Queries.StudentQueries;
using SMS.Application.Features.Students.Responses.Student;
using SMS.Core.Entity.StudentModel;

namespace SMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentPersonalController : ControllerBase
    {
        private readonly IMediator _mediator;
        public StudentPersonalController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("GetAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<List<StudentPersonal>> Get()
        {
            return await _mediator.Send(new GetAllStudentPersonalQuery());
        }

        [HttpGet("GetByFirstName/{fname}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<List<StudentPersonal>> GetByFirstName(string fname)
        {
            return await _mediator.Send(new GetStudentByFirstNameQuery() { FirstName = fname });
        }

        [HttpGet("GetByEmail/{email}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<List<StudentPersonal>> GetStudentByEmail(string email)
        {
            return await _mediator.Send(new GetStudentByEmailIdQuery() { Email = email });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<StudentPersonalResponse>> CreateStudent([FromBody] CreateStudentPersonalCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
