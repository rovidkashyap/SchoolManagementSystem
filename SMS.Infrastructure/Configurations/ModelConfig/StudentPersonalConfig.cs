using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SMS.Core.Entity.Academics;
using SMS.Core.Entity.Others;
using SMS.Core.Entity.StudentModel;

namespace SMS.Infrastructure.Configurations.ModelConfig
{
    public class StudentPersonalConfig : IEntityTypeConfiguration<StudentPersonal>
    {
        public void Configure(EntityTypeBuilder<StudentPersonal> builder)
        {
            builder.ToTable("StudentPersonal");
            builder.HasKey(x => x.StudentId);

            builder.Property(x => x.StudentId).UseIdentityColumn();
            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.Email).IsRequired().HasMaxLength(250);
            builder.Property(x => x.Mobile).IsRequired().HasMaxLength(12);

            builder.HasData(new List<StudentPersonal>() {
                new StudentPersonal() { StudentId = 10001, FirstName = "Ashish", LastName = "Singh", FatherName = "Ravi Singh", gender = Gender.Male.ToString(), 
                    MotherName = "Urmi Singh", GuardianName = "Shiv Dubey", Email = "ashish.singh@gmail.com", Mobile = "9045102010", ClassId = 1001, SectionId = 1111 },

                new StudentPersonal() { StudentId = 10002, FirstName = "Arjun", LastName = "Singh", FatherName = "Rohan Singh", gender = Gender.Male.ToString(),
                    MotherName = "Laxmi Singh", GuardianName = "Rishab Yadav", Email = "arjun.singh@gmail.com", Mobile = "9760332211", ClassId = 1002, SectionId = 1112 },

                new StudentPersonal() { StudentId = 10003, FirstName = "Pooja", LastName = "Tomar", FatherName = "Ravi Tomar", gender = Gender.Female.ToString(),
                    MotherName = "Shweta Tomar", GuardianName = "Ashish Chanchal", Email = "pooja.tomar@gmail.com", Mobile = "7854122321", ClassId = 1003, SectionId = 1111 },

                new StudentPersonal() { StudentId = 10004, FirstName = "Rashi", LastName = "Verma", FatherName = "Pankaj Verma", gender = Gender.Female.ToString(), 
                    MotherName = "Rashmi Verma", GuardianName = "Ashok Nagar", Email = "rashi.verma@gmail.com", Mobile = "9897202010", ClassId = 1004, SectionId = 1113 },
            });
        }
    }
}
