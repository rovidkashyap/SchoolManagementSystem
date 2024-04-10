using MediatR;
using SMS.Application.Features.Students.Queries.AcademicsQueries;
using SMS.Core.Entity.Academics;
using SMS.Core.Repository.Academics;

namespace SMS.Application.Features.Students.Handlers.QueryHandlers.AcademicsQueries
{
    public class GetAllSectionQueryHandler : IRequestHandler<GetAllSection, List<Section>>
    {
        private readonly ISectionRepository _sectionRepository;
        public GetAllSectionQueryHandler(ISectionRepository sectionRepository)
        {
            _sectionRepository = sectionRepository;
        }

        public async Task<List<Section>> Handle(GetAllSection request, CancellationToken cancellationToken)
        {
            return (List<Section>)await _sectionRepository.GetAllAsync();
        }
    }
}
