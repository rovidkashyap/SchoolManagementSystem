using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Application.Features.Students.Queries.AcademicsQueries
{
    public class GetAllSection : IRequest<List<Core.Entity.Academics.Section>>
    {
    }
}
