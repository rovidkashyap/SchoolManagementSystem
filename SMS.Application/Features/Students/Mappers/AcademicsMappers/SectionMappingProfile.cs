using AutoMapper;
using SMS.Application.Features.Students.Commands.AcademicsCommands;
using SMS.Application.Features.Students.Responses.Academics;
using SMS.Core.Entity.Academics;

namespace SMS.Application.Features.Students.Mappers.AcademicsMappers
{
    public class SectionMappingProfile : Profile
    {
        public SectionMappingProfile()
        {
            CreateMap<Section, SectionResponse>().ReverseMap();
            CreateMap<Section, CreateSectionCommand>().ReverseMap();
        }
    }
}
