using MediatR;
using SMS.Application.Features.Students.Queries.StudentQueries;
using SMS.Core.Entity.StudentModel;
using SMS.Core.Repository.Student;

namespace SMS.Application.Features.Students.Handlers.QueryHandlers.StudentQueries
{
    public class GetAllStudentPersonalQueryHandler : IRequestHandler<GetAllStudentPersonalQuery, List<StudentPersonal>>
    {
        private readonly IStudentPersonalRepository _studentRepository;
        public GetAllStudentPersonalQueryHandler(IStudentPersonalRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<List<StudentPersonal>> Handle(GetAllStudentPersonalQuery request, CancellationToken cancellationToken)
        {
            return (List<StudentPersonal>)await _studentRepository.GetAllAsync();
        }
    }
}
