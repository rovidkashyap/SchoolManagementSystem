using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Application.Features.Students.Queries.StudentQueries
{
    public class GetStudentByEmailIdQuery : IRequest<List<Core.Entity.StudentModel.StudentPersonal>>
    {
        public string Email { get; set; }
    }
}
