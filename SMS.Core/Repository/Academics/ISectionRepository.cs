using SMS.Core.Entity.Academics;
using SMS.Core.Repository.Base;

namespace SMS.Core.Repository.Academics
{
    public interface ISectionRepository : IRepository<Section>
    {
        Task<IEnumerable<Section>> GetSectionById(int id);
    }
}
