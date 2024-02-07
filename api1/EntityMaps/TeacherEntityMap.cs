using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaavSchool.Entitis.Entitis;

namespace api1.EntityMaps
{
    internal class TeacherEntityMap : IEntityTypeConfiguration<Teacher>
    {
        public void Configure(EntityTypeBuilder<Teacher> builder)
        {
            builder.HasKey(_ => _.Id);
            builder.Property(_ => _.Id).ValueGeneratedOnAdd();
            builder.Property(_ => _.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(_ => _.Salary).HasPrecision(18, 4).IsRequired();

            builder
                 .HasMany(_ => _.TeacherCourses)
                 .WithOne(_ => _.Teacher)
                 .HasForeignKey(_ => _.TeacherId)
                 .OnDelete(DeleteBehavior.NoAction);






        }
    }
}
