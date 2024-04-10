using Microsoft.EntityFrameworkCore;
using SMS.Core.Entity.Academics;
using SMS.Core.Repository.Academics;
using SMS.Infrastructure.Context;
using SMS.Infrastructure.Repository.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Infrastructure.Repository.Academics
{
    public class ClassRepository : Repository<Class>, IClassRepository
    {
        public ClassRepository(DataContext context) : base(context)
        {
            
        }
        public async Task<IEnumerable<Class>> GetClassById(int id)
        {
            return await _context.Class.Where(x => x.ClassId == id).ToListAsync();
        }
    }
}
