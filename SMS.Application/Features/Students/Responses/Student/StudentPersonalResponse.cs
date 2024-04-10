using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Application.Features.Students.Responses.Student
{
    public class StudentPersonalResponse
    {
        public int StudentId { get; set; }
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
