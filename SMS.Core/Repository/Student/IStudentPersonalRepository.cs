using SMS.Core.Entity.StudentModel;
using SMS.Core.Repository.Base;

namespace SMS.Core.Repository.Student
{
    public interface IStudentPersonalRepository : IRepository<Core.Entity.StudentModel.StudentPersonal>
    {
        Task<IEnumerable<Core.Entity.StudentModel.StudentPersonal>> GetStudentById(int id);
        Task<IEnumerable<Core.Entity.StudentModel.StudentPersonal>> GetStudentByFirstName(string fname);
        Task<IEnumerable<Core.Entity.StudentModel.StudentPersonal>> GetStudentByEmailId(string email);
    }
}
