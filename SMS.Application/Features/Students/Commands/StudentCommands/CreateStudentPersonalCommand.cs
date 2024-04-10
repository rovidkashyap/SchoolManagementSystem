using MediatR;
using SMS.Application.Features.Students.Responses.Student;
using System.Net;

namespace SMS.Application.Features.Students.Commands.StudentCommands
{
    public class CreateStudentPersonalCommand : IRequest<StudentPersonalResponse>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string GuardianName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }

        public string gender { get; set; }

        //public int ClassId { get; set; }
        //public int SectionId { get; set; }
    }
}
