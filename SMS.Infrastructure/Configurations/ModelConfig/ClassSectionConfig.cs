using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMS.Core.Entity.Academics;

namespace SMS.Infrastructure.Configurations.ModelConfig
{
    public class ClassSectionConfig : IEntityTypeConfiguration<Section>
    {
        public void Configure(EntityTypeBuilder<Section> builder)
        {
            builder.ToTable("Section");
            builder.HasKey(x => x.SectionId);

            builder.Property(x => x.SectionId).UseIdentityColumn();
            builder.Property(x => x.SectionName).IsRequired().HasMaxLength(100);

            builder.HasData(new List<Section>() {
                new Section(){ SectionId = 1111, SectionName = "A" },
                new Section(){ SectionId = 1112, SectionName = "B" },
                new Section(){ SectionId = 1113, SectionName = "C" },
                new Section(){ SectionId = 1114, SectionName = "D" }
            });
        }
    }
}
