using MediatR;
using SMS.Core.Entity.Academics;

namespace SMS.Application.Features.Students.Queries.AcademicsQueries
{
    public class GetSectionById : IRequest<List<Section>>
    {
        public int SectionId { get; set; }
    }
}
