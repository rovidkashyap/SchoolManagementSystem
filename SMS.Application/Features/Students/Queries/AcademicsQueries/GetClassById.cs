using MediatR;
using SMS.Core.Entity.Academics;

namespace SMS.Application.Features.Students.Queries.AcademicsQueries
{
    public class GetClassById : IRequest<Class>
    {
        public int ClassId { get; set; }
    }
}
