using Microsoft.EntityFrameworkCore;
using SMS.Core.Common;
using SMS.Core.Entity.Academics;
using SMS.Core.Entity.StudentModel;
using SMS.Core.Services;
using SMS.Infrastructure.Configurations.ModelConfig;

namespace SMS.Infrastructure.Context
{
    public class DataContext : DbContext
    {
        private readonly IDateTimeService _dateTime;
        public DataContext(DbContextOptions<DataContext> options, IDateTimeService dateTime)
            :base(options)
        {
            _dateTime = dateTime;
        }

        public DbSet<Section> Section { get; set; }
        public DbSet<Class> Class { get; set; }
        public DbSet<StudentPersonal> StudentPersonal { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SchoolClassConfig());
            modelBuilder.ApplyConfiguration(new ClassSectionConfig());
            modelBuilder.ApplyConfiguration(new StudentPersonalConfig());
        }

        public override Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreateDate = _dateTime.ISTNow;
                        break;
                    case EntityState.Modified:
                        entry.Entity.UpdatedDate = _dateTime.ISTNow;
                        break;
                }
            }

            return base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }
    }
}
