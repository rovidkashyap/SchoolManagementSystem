using MediatR;
using SMS.Application.Features.Students.Queries.AcademicsQueries;
using SMS.Core.Entity.Academics;
using SMS.Core.Repository.Academics;

namespace SMS.Application.Features.Students.Handlers.QueryHandlers.AcademicsQueries
{
    public class GetAllClassQueryHandler : IRequestHandler<GetAllClass, List<Class>>
    {
        private readonly IClassRepository _classRepository;
        public GetAllClassQueryHandler(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }

        public async Task<List<Class>> Handle(GetAllClass request, CancellationToken cancellationToken)
        {
            return (List<Class>)await _classRepository.GetAllAsync();
        }
    }
}
