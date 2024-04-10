using AutoMapper;
using SMS.Application.Features.Students.Commands.AcademicsCommands;
using SMS.Application.Features.Students.Responses.Academics;
using SMS.Core.Entity.Academics;

namespace SMS.Application.Features.Students.Mappers.AcademicsMappers
{
    public class ClassMappingProfile : Profile
    {
        public ClassMappingProfile()
        {
            CreateMap<Class, ClassResponse>().ReverseMap();
            CreateMap<Class, CreateClassCommand>().ReverseMap();
        }
    }
}
