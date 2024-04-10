using MediatR;
using SMS.Application.Features.Students.Commands.AcademicsCommands;
using SMS.Application.Features.Students.Mappers.AcademicsMappers;
using SMS.Application.Features.Students.Responses.Academics;
using SMS.Core.Entity.Academics;
using SMS.Core.Repository.Academics;

namespace SMS.Application.Features.Students.Handlers.CommandHandlers.AcademicsHandlers
{
    public class CreateClassCommandHandler : IRequestHandler<CreateClassCommand, ClassResponse>
    {
        private readonly IClassRepository _classRepository;
        public CreateClassCommandHandler(IClassRepository classRepository)
        {
            _classRepository = classRepository;
        }

        public async Task<ClassResponse> Handle(CreateClassCommand request, CancellationToken cancellationToken)
        {
            var classRepo = ClassMapper.Mapper.Map<Class>(request);
            if (classRepo is null)
                throw new ApplicationException("issue with mapper");

            var newClassRepo = await _classRepository.AddAsync(classRepo);
            var classResponse = ClassMapper.Mapper.Map<ClassResponse>(newClassRepo);

            return classResponse;
        }
    }
}
