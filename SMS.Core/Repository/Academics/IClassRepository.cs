using SMS.Core.Entity.Academics;
using SMS.Core.Repository.Base;

namespace SMS.Core.Repository.Academics
{
    public interface IClassRepository : IRepository<Class>
    {
        Task<IEnumerable<Class>> GetClassById(int id);
    }
}
