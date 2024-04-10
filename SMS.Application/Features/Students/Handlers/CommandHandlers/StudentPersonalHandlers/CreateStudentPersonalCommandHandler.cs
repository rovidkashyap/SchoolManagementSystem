using MediatR;
using SMS.Application.Features.Students.Commands.StudentCommands;
using SMS.Application.Features.Students.Mappers.StudentMappers;
using SMS.Application.Features.Students.Responses.Student;
using SMS.Core.Entity.StudentModel;
using SMS.Core.Repository.Student;

namespace SMS.Application.Features.Students.Handlers.CommandHandlers.StudentPersonalHandlers
{
    public class CreateStudentPersonalCommandHandler : IRequestHandler<CreateStudentPersonalCommand, StudentPersonalResponse>
    {
        private readonly IStudentPersonalRepository _studentPersonalRepository;
        public CreateStudentPersonalCommandHandler(IStudentPersonalRepository studentPersonalRepository)
        {
            _studentPersonalRepository = studentPersonalRepository;
        }

        public async Task<StudentPersonalResponse> Handle(CreateStudentPersonalCommand request, CancellationToken cancellationToken)
        {
            var studentPersonal = StudentPersonalMapper.Mapper.Map<StudentPersonal>(request);
            if (studentPersonal is null)
                throw new ApplicationException("issue with mapper");

            var newStudentPersonal = await _studentPersonalRepository.AddAsync(studentPersonal);
            var studentPersonalResponse = StudentPersonalMapper.Mapper.Map<StudentPersonalResponse>(newStudentPersonal);

            return studentPersonalResponse;
        }
    }
}
