using MediatR;
using SMS.Application.Features.Students.Queries.AcademicsQueries;
using SMS.Core.Entity.Academics;
using SMS.Core.Repository.Academics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Application.Features.Students.Handlers.QueryHandlers.AcademicsQueries
{
    public class GetSectionByIdQueryHandler : IRequestHandler<GetSectionById, List<Section>>
    {
        private static ISectionRepository _sectionRepository;
        public GetSectionByIdQueryHandler(ISectionRepository sectionRepository)
        {
            _sectionRepository = sectionRepository;
        }

        public async Task<List<Section>> Handle(GetSectionById request, CancellationToken cancellationToken)
        {
            return (List<Section>)await _sectionRepository.GetSectionById(request.SectionId);
        }
    }
}
