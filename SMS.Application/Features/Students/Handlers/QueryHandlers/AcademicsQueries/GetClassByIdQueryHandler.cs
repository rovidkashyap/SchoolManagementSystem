using MediatR;
using SMS.Application.Features.Students.Queries.AcademicsQueries;
using SMS.Core.Entity.Academics;
using SMS.Core.Repository.Academics;

namespace SMS.Application.Features.Students.Handlers.QueryHandlers.AcademicsQueries
{
    public class GetClassByIdQueryHandler : IRequestHandler<GetClassById, Class>
    {
        private static IClassRepository _classRepository;
        public GetClassByIdQueryHandler(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }

        public async Task<Class> Handle(GetClassById request, CancellationToken cancellationToken)
        {
            return (Class)await _classRepository.GetByIdAsync(request.ClassId);
        }
    }
}
