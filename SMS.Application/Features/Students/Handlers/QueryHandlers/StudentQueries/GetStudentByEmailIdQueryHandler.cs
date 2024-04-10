using MediatR;
using SMS.Application.Features.Students.Queries.StudentQueries;
using SMS.Core.Entity.StudentModel;
using SMS.Core.Repository.Student;

namespace SMS.Application.Features.Students.Handlers.QueryHandlers.StudentQueries
{
    public class GetStudentByEmailIdQueryHandler : IRequestHandler<GetStudentByEmailIdQuery, List<StudentPersonal>>
    {
        private readonly IStudentPersonalRepository _studentRepository;
        public GetStudentByEmailIdQueryHandler(IStudentPersonalRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<List<StudentPersonal>> Handle(GetStudentByEmailIdQuery request, CancellationToken cancellationToken)
        {
            return (List<StudentPersonal>)await _studentRepository.GetStudentByEmailId(request.Email);
        }
    }
}
