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
    public class SectionController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SectionController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("GetAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<List<Section>> Get()
        {
            return await _mediator.Send(new GetAllSection());
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<List<Section>> GetSectionById(int id)
        {
            return await _mediator.Send(new GetSectionById() { SectionId = id });
        }

        [HttpPost]
        [Route("Create")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<SectionResponse>> CreateSection([FromBody] CreateSectionCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
