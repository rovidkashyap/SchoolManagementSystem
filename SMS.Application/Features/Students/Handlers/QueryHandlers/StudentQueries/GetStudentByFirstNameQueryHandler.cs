using MediatR;
using SMS.Application.Features.Students.Queries.StudentQueries;
using SMS.Core.Entity.StudentModel;
using SMS.Core.Repository.Student;

namespace SMS.Application.Features.Students.Handlers.QueryHandlers.StudentQueries
{
    public class GetStudentByFirstNameQueryHandler : IRequestHandler<GetStudentByFirstNameQuery, List<StudentPersonal>>
    {
        private readonly IStudentPersonalRepository _studentRepository;
        public GetStudentByFirstNameQueryHandler(IStudentPersonalRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<List<StudentPersonal>> Handle(GetStudentByFirstNameQuery request, CancellationToken cancellationToken)
        {
            return (List<StudentPersonal>)await _studentRepository.GetStudentByFirstName(request.FirstName);
        }
    }
}
