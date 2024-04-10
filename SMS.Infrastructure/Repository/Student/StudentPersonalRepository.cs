using Microsoft.EntityFrameworkCore;
using SMS.Core.Entity.StudentModel;
using SMS.Core.Repository.Student;
using SMS.Infrastructure.Context;
using SMS.Infrastructure.Repository.Base;

namespace SMS.Infrastructure.Repository.Student
{
    public class StudentPersonalRepository : Repository<Core.Entity.StudentModel.StudentPersonal>, IStudentPersonalRepository
    {
        public StudentPersonalRepository(DataContext context): base(context)
        {
            
        }

        public async Task<IEnumerable<StudentPersonal>> GetStudentByEmailId(string email)
        {
            return await _context.StudentPersonal.Where(x => x.Email == email).ToListAsync();
        }

        public async Task<IEnumerable<StudentPersonal>> GetStudentByFirstName(string fname)
        {
            return await _context.StudentPersonal.Where(x => x.FirstName == fname).ToListAsync();
        }

        public async Task<IEnumerable<StudentPersonal>> GetStudentById(int id)
        {
            return await _context.StudentPersonal.Where(x => x.StudentId == id).ToListAsync();
        }
    }
}
