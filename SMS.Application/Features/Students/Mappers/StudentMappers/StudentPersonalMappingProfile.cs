using AutoMapper;
using SMS.Application.Features.Students.Commands.StudentCommands;
using SMS.Application.Features.Students.Responses.Student;
using SMS.Core.Entity.StudentModel;

namespace SMS.Application.Features.Students.Mappers.StudentMappers
{
    public class StudentPersonalMappingProfile : Profile
    {
        public StudentPersonalMappingProfile()
        {
            CreateMap<StudentPersonal, StudentPersonalResponse>().ReverseMap();
            CreateMap<StudentPersonal, CreateStudentPersonalCommand>().ReverseMap();
        }
    }
}
