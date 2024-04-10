using MediatR;

namespace SMS.Application.Features.Students.Queries.StudentQueries
{
    public class GetStudentByFirstNameQuery : IRequest<List<Core.Entity.StudentModel.StudentPersonal>>
    {
        public string FirstName { get; set; }
    }
}
