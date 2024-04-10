using MediatR;
using SMS.Application.Features.Students.Responses.Academics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Application.Features.Students.Commands.AcademicsCommands
{
    public class CreateSectionCommand : IRequest<SectionResponse>
    {
        public string SectionName { get; set; }
    }
}
