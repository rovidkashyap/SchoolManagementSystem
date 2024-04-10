using MediatR;
using SMS.Application.Features.Students.Responses.Academics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Application.Features.Students.Commands.AcademicsCommands
{
    public class CreateClassCommand : IRequest<ClassResponse>
    {
        public string ClassName { get; set; }
    }
}
