using MediatR;
using Microsoft.AspNetCore.Mvc;
using SMS.Application.Features.Students.Commands.AcademicsCommands;
using SMS.Application.Features.Students.Queries.AcademicsQueries;
using SMS.Application.Features.Students.Responses.Academics;
using SMS.Core.Entity.Academics;

namespace SMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ClassController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("GetAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<List<Class>> Get()
        {
            return await _mediator.Send(new GetAllClass());
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<Class> GetById(int id)
        {
            return await _mediator.Send(new GetClassById() { ClassId = id });
        }

        [HttpPost]
        [Route("Create")]
        [ValidateAntiForgeryToken]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<ClassResponse>> CreateClass([FromBody] CreateClassCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
