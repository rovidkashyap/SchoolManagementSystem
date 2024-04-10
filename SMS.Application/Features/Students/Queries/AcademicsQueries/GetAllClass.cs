using MediatR;

namespace SMS.Application.Features.Students.Queries.AcademicsQueries
{
    public class GetAllClass : IRequest<List<Core.Entity.Academics.Class>>
    {
    }
}
