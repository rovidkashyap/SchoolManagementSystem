using MediatR;

namespace SMS.Application.Features.Students.Queries.StudentQueries
{
    public class GetAllStudentPersonalQuery : IRequest<List<Core.Entity.StudentModel.StudentPersonal>>
    {
    }
}
