using MediatR;
using SMS.Application.Features.Students.Commands.AcademicsCommands;
using SMS.Application.Features.Students.Mappers.AcademicsMappers;
using SMS.Application.Features.Students.Responses.Academics;
using SMS.Core.Entity.Academics;
using SMS.Core.Repository.Academics;

namespace SMS.Application.Features.Students.Handlers.CommandHandlers.AcademicsHandlers
{
    public class CreateSectionCommandHandler : IRequestHandler<CreateSectionCommand, SectionResponse>
    {
        private readonly ISectionRepository _sectionRespository;
        public CreateSectionCommandHandler(ISectionRepository sectionRepository)
        {
            _sectionRespository = sectionRepository;
        }

        public async Task<SectionResponse> Handle(CreateSectionCommand request, CancellationToken cancellationToken)
        {
            var section = SectionMapper.Mapper.Map<Section>(request);
            if (section is null)
                throw new ApplicationException("issue with mapper");

            var newSection = await _sectionRespository.AddAsync(section);
            var newSectionRepo = SectionMapper.Mapper.Map<SectionResponse>(newSection);

            return newSectionRepo;
        }
    }
}
