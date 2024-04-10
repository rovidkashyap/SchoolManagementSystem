using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMS.Core.Entity.Academics;

namespace SMS.Infrastructure.Configurations.ModelConfig
{
    public class SchoolClassConfig : IEntityTypeConfiguration<Class>
    {
        public void Configure(EntityTypeBuilder<Class> builder)
        {
            builder.ToTable("Class");
            builder.HasKey(x => x.ClassId);

            builder.Property(x => x.ClassId).UseIdentityColumn();
            builder.Property(x => x.ClassName).IsRequired().HasMaxLength(100);

            builder.HasData(new List<Class>() {
                new Class(){ ClassId = 1001, ClassName = "Class 1" },
                new Class(){ ClassId = 1002, ClassName = "Class 2" },
                new Class(){ ClassId = 1003, ClassName = "Class 3" },
                new Class(){ ClassId = 1004, ClassName = "Class 4" }
            });
        }
    }
}
