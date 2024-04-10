using Microsoft.EntityFrameworkCore;
using SMS.Core.Entity.Academics;
using SMS.Core.Repository.Academics;
using SMS.Infrastructure.Context;
using SMS.Infrastructure.Repository.Base;

namespace SMS.Infrastructure.Repository.Academics
{
    public class SectionRepository : Repository<Section>, ISectionRepository
    {
        public SectionRepository(DataContext context) : base(context)
        {
            
        }
        public async Task<IEnumerable<Section>> GetSectionById(int id)
        {
            return await _context.Section.Where(x => x.SectionId == id).ToListAsync();
        }
    }
}
